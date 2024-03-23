
namespace CloudProvider.Services
{
    internal class DropBox : ICloudProvider
    {
        public void CreateServer(string region)
        {
            throw new NotImplementedException();
        }

        public string GetCDNAAddress()
        {
            throw new NotImplementedException();
        }

        public string GetFileName(string name)
        {
            return "DropBox Get File Name";
        }

        public List<string> ListServers(string region)
        {
            throw new NotImplementedException();
        }

        public void StoreProvider(string name)
        {
            Console.WriteLine("DropBox Store Provider");
        }
    }
}
