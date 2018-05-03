using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DataObjects
{
    public class CollectionDeletion<T> where T : class,  IDuplicate, IModel, new()
    {
        private object _iDialogService;
        private ExtRangeCollection<T> _parent;


        public CollectionDeletion(object iDialogService, ExtRangeCollection<T> parent)
        {
            _iDialogService = iDialogService;
            _parent = parent;
        }

        private List<T> _records;

        private List<T> _originalRecords = new List<T>();


        // private T _selectedRecord;

        public void AddRecords(List<T> records)
        {
            _records = records;

            _originalRecords = new List<T>();

            _originalRecords.AddRange(_records);
        }

        public IEnumerable<T> DeletedRecords()
        {
            var newList = new List<T>();

            foreach (var v in _originalRecords)
            {
                if (!_records.Contains(v))
                {
                    newList.Add(v);
                }
            }

            return newList;
        }

        public Task<T> Delete(Predicate<T> delPredicate)
        {
            throw new NotImplementedException();

        }

        public T DeleteNoUI(Predicate<T> delPredicate)
        {
            if (delPredicate != null)
                _records.RemoveAll(delPredicate);

            if (_records.Count > 0)
                return _records.First();

            return new T();
        }

    }

    public class ValidationArgs
    {
        public bool IsValidToDelete { get; set; }

        public bool IsValidToSave { get; set; }
    }


    public sealed class ExtRangeCollection<T> : ObservableCollection<T>  where T : class , IDuplicate, IModel,new()
    {

        public event Action<object, object> OnValidation;


        public event Action<object,string> OnCollectionUpdated;

        private List<T> _rollbackList = new List<T>();

        private CollectionDeletion<T> _deleter;


        public int ChangeCount => _rollbackList.Count;

        public override event NotifyCollectionChangedEventHandler CollectionChanged
        {
            add => base.CollectionChanged += value;

            remove => base.CollectionChanged -= value;
        }

        public Task<T> Delete(Predicate<T> delPredicate)
        {


            return _deleter.Delete(delPredicate).ContinueWith((a) =>
            {

                //SelectedWpIncomeDto = a.Result;

                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

                return a.Result;

            }, TaskScheduler.FromCurrentSynchronizationContext()); 


        }

        public void Rollback()
        {
            foreach (var r in _rollbackList)
                _deleter.DeleteNoUI(p => p.RecordId == r.RecordId);


            foreach(var item in Items)
                item.ResetChanges();

            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));


            _rollbackList.Clear();
        }

        public void Test2()
        {

            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public void AddDuplicate(T existing, int numberoftimes)
        {
            if (existing == null) return; // it wont work unless we have a selected income

            int idx = 1;

            while (idx < (numberoftimes+1))
            {
                var newIncome = new T();

                newIncome.MakeFromExisting(existing, 0 - idx);


                this.AddItem(newIncome,true);
                idx++;
            }
        }


        public bool Errors()
        {
            int errorCount = 0;

            foreach (var item in Items)
                errorCount += item.Errors.Count;


            return errorCount != 0;
        }

        /// <summary> 
        /// Initializes a new instance of the System.Collections.ObjectModel.ObservableCollection(Of T) class. 
        /// </summary> 
        public ExtRangeCollection(object iDialogService=null)
            : base()
        {
            this.OnCollectionUpdated += (obj,obj2) =>
            {
                ExValidate();
            };

            this.CollectionChanged += (sender, e) =>
            {
                ExValidate();
            };

            this.PropertyChanged += (object sender, PropertyChangedEventArgs e)=>{
            //    Debug.WriteLine("prop changed in ex collection");
            };

            _deleter = new CollectionDeletion<T>(iDialogService,this);
        }

 

        private void ExValidate()
        {
            var validModel = true;
            var modelChanged = false;

            var va = new ValidationArgs()
            {
                IsValidToDelete = false,
                IsValidToSave = false
            };

            foreach (var incomeEditDto in Items)
            {
                if (incomeEditDto is IModel tp)
                {
                    tp.Validate();

                    if (!tp.IsValid)
                        validModel = false;

                    if (tp.IsDirty)
                        modelChanged = true;
                }
            }

            va.IsValidToSave = (validModel && modelChanged);
            va.IsValidToDelete = (Items.Count > 0);

            OnValidation?.Invoke(this, va);

        }

        /// <summary> 
        /// Initializes a new instance of the System.Collections.ObjectModel.ObservableCollection(Of T) class that contains elements copied from the specified collection. 
        /// </summary> 
        /// <param name="collection">collection: The collection from which the elements are copied.</param> 
        /// <exception cref="System.ArgumentNullException">The collection parameter cannot be null.</exception> 
        public ExtRangeCollection(IEnumerable<T> collection)
            : base(collection)
        {
        }

        /// <summary> 
        /// Adds the elements of the specified collection to the end of the ObservableCollection(Of T). 
        /// </summary> 
        private void AddRange(IEnumerable<T> collection, NotifyCollectionChangedAction notificationMode = NotifyCollectionChangedAction.Add)
        {
            if (notificationMode != NotifyCollectionChangedAction.Add && notificationMode != NotifyCollectionChangedAction.Reset)
                throw new ArgumentException("Mode must be either Add or Reset for AddRange.", nameof(notificationMode));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            CheckReentrancy();


            foreach (var c in collection)
            {
                SetEvents(c);
            }

            if (notificationMode == NotifyCollectionChangedAction.Reset)
            {
                foreach (var i in collection)
                    Items.Add(i);

                _deleter.AddRecords((List<T>)Items);

                OnPropertyChanged(new PropertyChangedEventArgs("Count"));
                OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

                return;
            }

            int startIndex = Count;
            var changedItems = collection is List<T> ? (List<T>)collection : new List<T>(collection);
            foreach (var i in changedItems)
                Items.Add(i);

            _deleter.AddRecords((List<T>)Items);


            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, changedItems, changedItems.Count-1));
        }

        private void SetEvents(T c)
        {
            if (!(c is IModel imodel)) return;

            imodel.SetPropChanged();

            imodel.PropertyChanged += (sender, e) =>
            {
                string updatedProperty = "";

                if (e is ExtPropertyChangedEventArgs temp)
                {
                    if (temp.Tag != null)
                        updatedProperty = temp.Tag;
                }

                if (sender is IModel)
                    OnCollectionUpdated?.Invoke(sender, updatedProperty);
            };

        }

        public void AddItem(T item, bool saveForRollback=false)
        {
            AddRange(new T[] { item });

            if(saveForRollback)
                _rollbackList.Add(item);
        }

        /// <summary> 
        /// Removes the first occurence of each item in the specified collection from ObservableCollection(Of T). NOTE: with notificationMode = Remove, removed items starting index is not set because items are not guaranteed to be consecutive.
        /// </summary> 
        public void RemoveRange(IEnumerable<T> collection, NotifyCollectionChangedAction notificationMode = NotifyCollectionChangedAction.Reset)
        {
            if (notificationMode != NotifyCollectionChangedAction.Remove && notificationMode != NotifyCollectionChangedAction.Reset)
                throw new ArgumentException("Mode must be either Remove or Reset for RemoveRange.", nameof(notificationMode));
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            CheckReentrancy();

            if (notificationMode == NotifyCollectionChangedAction.Reset)
            {

                foreach (var i in collection)
                    Items.Remove(i);

                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

                return;
            }

            var changedItems = collection is List<T> ? (List<T>)collection : new List<T>(collection);
            for (int i = 0; i < changedItems.Count; i++)
            {
                if (!Items.Remove(changedItems[i]))
                {
                    changedItems.RemoveAt(i); //Can't use a foreach because changedItems is intended to be (carefully) modified
                    i--;
                }
            }

            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, changedItems, -1));
        }

        /// <summary> 
        /// Clears the current collection and replaces it with the specified item. 
        /// </summary> 
        public void Replace(T item) => ReplaceRange(new T[] { item });

        /// <summary> 
        /// Clears the current collection and replaces it with the specified collection. 
        /// </summary> 
        public void ReplaceRange(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException("collection");

            Items.Clear();
            AddRange(collection, NotifyCollectionChangedAction.Reset);

            _rollbackList.Clear();
        }

        public void Dispose()
        {
            foreach (var i in Items)
            {
                i.Dispose();
            }
        }



    }
}
