

namespace CloudProvider.Services
{
    internal class Amazon : ICloudHostingProvider, ICDNProvider, ICloudStorageProvider
    {
        public void CreateServer(string region)
        {
            Console.WriteLine(region + "da server yaratildi");
        }

        public string GetCDNAddress()
        {
            return "CDNAddress";
        }

        public string GetFile(string name)
        {
            return name + "[Amazon]";
        }

        public void StoreFile(string name)
        {
            Console.WriteLine(name + " li fayl saqlandi. [Amazon]");
        }
        public List<string> ListServers(string region)
        {
            return new List<string>() {"Uzbekistan", "Tadjikistan", "Kirgizistan"};
        }

    }
}
