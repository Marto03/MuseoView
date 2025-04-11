using Database.Data;

namespace Database
{
    public static class DatabaseConfig
    {
        // Път до базата данни
        public static string DbPath
        {
            get
            {
                // Използваме директорията на приложението за съхранение на базата данни
                //string folderPath = FileSystem.AppDataDirectory;
                //return Path.Combine(folderPath, "museumDatabase.db");
                //DatabaseConfig.RequestStoragePermissions();

                string folderPath = FileSystem.Current.AppDataDirectory;
                //DeleteIfNeeded(Path.Combine(folderPath, "museumDatabase.db"));


                //string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Downloads");
                //string folderPath = "/storage/emulated/0/Download";

                return Path.Combine(folderPath, "museumDatabase.db");
            }
        }

        public static void DeleteIfNeeded(string dbPath)
        {
            if (File.Exists(dbPath))
            {
                File.Delete(dbPath); // Изтриваме старата база
            }

        }
        //public static async Task RequestStoragePermissions()
        //{
        //    var status = await Permissions.CheckStatusAsync<Permissions.StorageRead>();

        //    if (status != PermissionStatus.Granted)
        //    {
        //        status = await Permissions.RequestAsync<Permissions.StorageRead>();
        //    }

        //    status = await Permissions.CheckStatusAsync<Permissions.StorageWrite>();

        //    if (status != PermissionStatus.Granted)
        //    {
        //        status = await Permissions.RequestAsync<Permissions.StorageWrite>();
        //    }
        //}
        //public static async Task CopyDatabaseToDownloads()
        //{
        //    try
        //    {
        //        // Оригинален път на базата (в защитената папка)
        //        string sourcePath = DbPath;

        //        // Публична папка "Downloads"
        //        string destinationPath = Path.Combine("/storage/emulated/0/Download", "museumDatabase.db");

        //        // Проверка дали базата съществува
        //        if (File.Exists(sourcePath))
        //        {
        //            File.Copy(sourcePath, destinationPath, true);
        //            await Shell.Current.DisplayAlert("Success", "Database copied to Downloads!", "OK");
        //        }
        //        else
        //        {
        //            await Shell.Current.DisplayAlert("Error", "Database not found!", "OK");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        //    }
        //}
    }
}
