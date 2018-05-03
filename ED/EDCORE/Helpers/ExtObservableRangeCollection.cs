//
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DataObjects
//{
//    public class CollectionDeletion<T> where T : class
//    {
//        private object _iDialogService;

//        public CollectionDeletion(object iDialogService)
//        {
//            _iDialogService = iDialogService;
//        }

//        private ExtRangeCollection<T> _records;

//        private readonly ExtRangeCollection<T> _originalRecords = new ExtRangeCollection<T>();


//        // private T _selectedRecord;

//        public void AddRecords(ExtRangeCollection<T> records)
//        {
//            _records = records;
//            _originalRecords.AddRange(_records);
//        }

//        public IEnumerable<T> DeletedRecords()
//        {
//            var newList = new List<T>();

//            foreach (var v in _originalRecords)
//            {
//                if (!_records.Contains(v))
//                {
//                    newList.Add(v);
//                }
//            }

//            return newList;
//        }

//        public Task<T> Delete(T selectedRecord)
//        {
//            Debug.WriteLine("Delete Commanded ");



//            return _iDialogService.Display().ContinueWith((a) =>
//            {
//                T newRecord = default(T);

//                if (a.Result)
//                {

//                    if (selectedRecord != null)
//                        _records.Remove(selectedRecord);


//                    if (_records.Count > 0)
//                        newRecord = _records.First();

//                }

//                return newRecord;

//            }, TaskScheduler.FromCurrentSynchronizationContext());

//        }

//    }


//    public class ValidationArgs
//    {
//        public bool IsValidToDelete { get; set; }

//        public bool IsValidToSave { get; set; }
//    }

//    public sealed class ExtRangeCollection<T> : ObservableCollection<T>
//    {

//        public event Action<object,object> OnValidation;


//        public event Action<object> OnCollectionUpdated;

    
//        public override event NotifyCollectionChangedEventHandler CollectionChanged
//        {
//            add => base.CollectionChanged += value;

//            remove => base.CollectionChanged -= value;
//        }


//        /// <summary> 
//        /// Initializes a new instance of the System.Collections.ObjectModel.ObservableCollection(Of T) class. 
//        /// </summary> 
//        public ExtRangeCollection(object iDialogService=null)
//            : base()
//        {
//            this.OnCollectionUpdated += (obj) =>
//            {
//                ExValidate();
//            };

//            this.CollectionChanged += (sender, e) =>
//            {
//                ExValidate();
//            };

//            var deleter = new CollectionDeletion<IncomeEditDTO>(iDialogService);
//        }

//        private void ExValidate()
//        {
//            var validModel = true;
//            var modelChanged = false;
 
//            var va = new ValidationArgs()
//            {
//                IsValidToDelete = false,
//                IsValidToSave = false
//            };

//            foreach (var incomeEditDto in Items)
//            {
//                if (incomeEditDto is IModel tp)
//                {
//                    tp.Validate();

//                    if (!tp.IsValid)
//                        validModel = false;

//                    if (tp.IsDirty)
//                        modelChanged = true;
//                }
//            }

//            va.IsValidToSave = (validModel && modelChanged);
//            va.IsValidToDelete = (Items.Count > 0);

//            OnValidation?.Invoke(this,va);
            
//        }

//        /// <summary> 
//        /// Initializes a new instance of the System.Collections.ObjectModel.ObservableCollection(Of T) class that contains elements copied from the specified collection. 
//        /// </summary> 
//        /// <param name="collection">collection: The collection from which the elements are copied.</param> 
//        /// <exception cref="System.ArgumentNullException">The collection parameter cannot be null.</exception> 
//        public ExtRangeCollection(IEnumerable<T> collection)
//            : base(collection)
//        {
//        }

//        /// <summary> 
//        /// Adds the elements of the specified collection to the end of the ObservableCollection(Of T). 
//        /// </summary> 
//        public void AddRange(IEnumerable<T> collection, NotifyCollectionChangedAction notificationMode = NotifyCollectionChangedAction.Add)
//        {
//            if (notificationMode != NotifyCollectionChangedAction.Add && notificationMode != NotifyCollectionChangedAction.Reset)
//                throw new ArgumentException("Mode must be either Add or Reset for AddRange.", nameof(notificationMode));
//            if (collection == null)
//                throw new ArgumentNullException(nameof(collection));

//            CheckReentrancy();


//            foreach (var c in collection)
//            {
//                SetEvents(c);
//            }

//            if (notificationMode == NotifyCollectionChangedAction.Reset)
//            {
//                foreach (var i in collection)
//                    Items.Add(i);

//                OnPropertyChanged(new PropertyChangedEventArgs("Count"));
//                OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
//                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

//                return;
//            }

//            int startIndex = Count;
//            var changedItems = collection is List<T> ? (List<T>)collection : new List<T>(collection);
//            foreach (var i in changedItems)
//                Items.Add(i);



          
//            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
//            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
//            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, changedItems, startIndex));
//        }

//        private void SetEvents(T c)
//        {
//            if (!(c is IModel imodel)) return;

//            imodel.SetPropChanged();

//            imodel.PropertyChanged += (sender, e) =>
//            {
//                if (sender is IModel)
//                    OnCollectionUpdated?.Invoke(sender);
//            };
    
//        }

//        public void AddItem(T item)
//        {         
//            AddRange(new T[] { item });            
//        }

//        /// <summary> 
//        /// Removes the first occurence of each item in the specified collection from ObservableCollection(Of T). NOTE: with notificationMode = Remove, removed items starting index is not set because items are not guaranteed to be consecutive.
//        /// </summary> 
//        public void RemoveRange(IEnumerable<T> collection, NotifyCollectionChangedAction notificationMode = NotifyCollectionChangedAction.Reset)
//        {
//            if (notificationMode != NotifyCollectionChangedAction.Remove && notificationMode != NotifyCollectionChangedAction.Reset)
//                throw new ArgumentException("Mode must be either Remove or Reset for RemoveRange.", nameof(notificationMode));
//            if (collection == null)
//                throw new ArgumentNullException(nameof(collection));

//            CheckReentrancy();

//            if (notificationMode == NotifyCollectionChangedAction.Reset)
//            {

//                foreach (var i in collection)
//                    Items.Remove(i);

//                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

//                return;
//            }

//            var changedItems = collection is List<T> ? (List<T>)collection : new List<T>(collection);
//            for (int i = 0; i < changedItems.Count; i++)
//            {
//                if (!Items.Remove(changedItems[i]))
//                {
//                    changedItems.RemoveAt(i); //Can't use a foreach because changedItems is intended to be (carefully) modified
//                    i--;
//                }
//            }

//            OnPropertyChanged(new PropertyChangedEventArgs("Count"));
//            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
//            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, changedItems, -1));
//        }

//        /// <summary> 
//        /// Clears the current collection and replaces it with the specified item. 
//        /// </summary> 
//        public void Replace(T item) => ReplaceRange(new T[] { item });

//        /// <summary> 
//        /// Clears the current collection and replaces it with the specified collection. 
//        /// </summary> 
//        public void ReplaceRange(IEnumerable<T> collection)
//        {
//            if (collection == null)
//                throw new ArgumentNullException("collection");

//            Items.Clear();
//            AddRange(collection, NotifyCollectionChangedAction.Reset);
//        }

//    }
//}
