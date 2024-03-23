
namespace CloudProvider.Services
{
    internal class Amazon : ICloudProvider
    {
        public void CreateServer(string region)
        {
            // statement
            Console.WriteLine("Amazaon, Create Server");
        }

        public string GetCDNAAddress()
        {
            return "Amazon Address";
        }

        public string GetFileName(string name)
        {
            return "Amazon, File Name";
        }

        public List<string> ListServers(string region)
        {
            return new List<string>();
        }

        public void StoreProvider(string name)
        {
            Console.WriteLine($"{name} Amazon Store Provider");   
        }
    }
}
