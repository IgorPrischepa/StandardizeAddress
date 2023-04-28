using StandardizeAddress.BLL.Models;

namespace StandardizeAddress.BLL.Contracts
{
    public interface IDadataService
    {
        public Task<AddressInfoModel> CheckAdressAsync(string address, CancellationToken cancellationToken = default);
    }
}