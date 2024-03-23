namespace CloudProvider.Services
{
    internal interface ICloudProvider
    {
        void StoreProvider(string name);
        string GetFileName(string name);
        void CreateServer(string region);
        List<string> ListServers(string region);
        string GetCDNAAddress();
    }
}
