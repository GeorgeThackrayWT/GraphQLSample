using SQLite.Net.Interop;

namespace Abstractions
{
    public interface IDBPlatformSettings
    {
        string GetFilePath();

        ISQLitePlatform GetPlatform();


    }
}