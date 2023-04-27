namespace StandardizeAddress.BLL.Contracts
{
    public interface IDadataService
    {
        public Task<string> CheckAdressAsync(string address, CancellationToken cancellationToken = default);
    }
}