
namespace CloudProvider.Services
{
    internal class DigitalOcean : ICloudStorageProvider
    {
        public string GetFile(string name)
        {
            return name + "[DigitalOcean]";
        }

        public void StoreFile(string name)
        {
            Console.WriteLine(name + " li fayl saqlandi. [DigitalOcean]");
        }
    }
}
