
namespace CloudProvider.Services
{
    internal class DropBox : ICloudStorageProvider
    {
        public string GetFile(string name)
        {
            return name + "[Dropbox]";
        }

        public void StoreFile(string name)
        {
            Console.WriteLine(name + " li fayl saqlandi. [Dropbox]");
        }
    }
}
