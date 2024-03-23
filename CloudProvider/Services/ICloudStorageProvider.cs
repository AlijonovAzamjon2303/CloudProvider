namespace CloudProvider.Services
{
    internal interface ICloudStorageProvider
    {
        void StoreFile(string name);
        string GetFile(string name);
    }
}
