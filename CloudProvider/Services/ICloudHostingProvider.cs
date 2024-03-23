namespace CloudProvider.Services
{
    internal interface ICloudHostingProvider
    {
        void CreateServer(string region);
        List<string> ListServers(string region);
    }
}
