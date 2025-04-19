using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Database.Data;

namespace BusinessLayer
{
    public static class MuseumServiceFactory
    {
        public static IMuseumService Create(string dbPath)
        {
            var db = new MuseumDatabase(dbPath);
            InitializeBase(db);       
            return new MuseumService(db);                // връщаш готовия service
        }
        private static async Task InitializeBase(MuseumDatabase db)
        {
            await db.InitializeDatabaseAsync();
        }
    }
}
