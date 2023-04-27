using Microsoft.Extensions.Logging;
using StandardizeAddress.BLL.Contracts;
using StandardizeAddress.BLL.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace StandardizeAddress.BLL.Services
{
    internal sealed class DadataService : IDadataService
    {
        private readonly ILogger<DadataService> _logger;
        private readonly HttpClient _httpClient;

        public DadataService(IHttpClientFactory httpClientFactory, ILogger<DadataService> logger)
        {
            _logger = logger;

            _logger.LogTrace("Start creating Dadata service instance");

            _logger.LogTrace("Requesting http client instance instance");

            _httpClient = httpClientFactory.CreateClient("Dadata");

            _logger.LogTrace($"Http client has bee created with base url = {_httpClient.BaseAddress}");
        }

        public async Task<string> CheckAdressAsync(string address, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException($"'{nameof(address)}' cannot be null or whitespace.", nameof(address));
            }

            _logger.LogInformation("Send request to DaData service");

            var response = await _httpClient.PostAsJsonAsync(string.Empty, new[] { address }, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogError($"Something wrong when fetching data : {response.StatusCode} {response.ReasonPhrase}");
            }

            _logger.LogInformation("Request completed successfully. Read body response...");

            // Обрабатываем ответ
            var responseContent = await response.Content.ReadAsStringAsync();

            AddressInfo[]? responeObj = JsonSerializer.Deserialize<AddressInfo[]>(responseContent.ToString());

            return JsonSerializer.Serialize(responeObj);
        }
    }
}
