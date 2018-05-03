using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Abstractions;
using DataObjects;
using SQLite.Net;

namespace Stores
{
    public class DebugTraceListener : ITraceListener
    {
        public void Receive(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public class BaseStore : IBaseStore
    {
        protected SQLite.Net.Async.SQLiteAsyncConnection _sqLiteAsyncConnection;

        protected SQLite.Net.SQLiteConnection _sqLiteSyncConnection;

        protected IDBPlatformSettings _platform;

        protected ISQLiteCache _iCache;

        protected ILookupStore _iLookupStore;

        protected IUserStore _iUserStore;

        public List<ComboBoxValue> GetYears()
        {
            throw new NotImplementedException();
        }

        protected SQLite.Net.Async.SQLiteAsyncConnection GetConnection()
        {
            var filePath = _platform.GetFilePath();
            var platform = _platform.GetPlatform();

         //   //Debug.WriteLine("obtaining connection");

            var connectionFactory = new Func<SQLite.Net.SQLiteConnectionWithLock>(() => new SQLite.Net.SQLiteConnectionWithLock(platform, new SQLite.Net.SQLiteConnectionString(filePath, storeDateTimeAsTicks: false)));


            var asyncConnection = new SQLite.Net.Async.SQLiteAsyncConnection(connectionFactory);

            

            return asyncConnection;
        }

        protected SQLite.Net.SQLiteConnection GetSynchConnection()
        {
            var filePath = _platform.GetFilePath();
            var platform = _platform.GetPlatform();

         //   //Debug.WriteLine("obtaining sync connection");
       
            return new SQLiteConnection(platform, filePath,false);
        }


     
        
    }





}

