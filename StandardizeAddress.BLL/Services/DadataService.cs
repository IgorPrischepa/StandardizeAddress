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

            _logger.LogTrace("Http client has bee created with base url = {BaseAddress}", _httpClient.BaseAddress);
        }

        /// <summary>
        ///  Send an address standardization request from a user to DaData service
        /// </summary>
        /// <param name="address">Input from user</param>
        /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when the 'address' parameter is null or whitespace.</exception>
        /// <exception cref="HttpRequestException">Thrown when there is an issue with the HTTP request to the DaData service.</exception>
        /// <exception cref="JsonException">Thrown when there is an issue with the deserialization of the response.</exception>
        public async Task<AddressInfoModel> CheckAdressAsync(string address, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException($"'{nameof(address)}' cannot be null or whitespace.", nameof(address));
            }

            _logger.LogInformation("Send request to DaData service");

            try
            {
                var response = await _httpClient.PostAsJsonAsync(string.Empty, new[] { address }, cancellationToken);

                response.EnsureSuccessStatusCode();

                _logger.LogInformation("Request completed successfully. Read body response...");

                var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

                AddressInfoModel responeObj = JsonSerializer.Deserialize<AddressInfoModel[]>(responseContent.ToString())?.FirstOrDefault()
                                           ?? throw new JsonException("Something wrong during deserialization. Result is null");

                _logger.LogInformation("Response has been received and read");

                return responeObj;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError("Something wrong when fetching data : {Message} {StatusCode} {ReasonPhrase}", ex.Message, ex.StatusCode, ex.StatusCode);
                throw;
            }
        }
    }
}