using Mexc.Net.Enums;
using Mexc.Net.Interfaces.Clients.SpotApi;
using Mexc.Net.Objects.Models.Spot;

namespace Mexc.Net.Clients.SpotApi
{
    /// <inheritdoc />
    internal class MexcRestClientSpotApiSubAccount : IMexcRestClientSpotApiSubAccount
    {
        private readonly MexcRestClientSpotApi _baseClient;
        private static readonly RequestDefinitionCache _definitions = new RequestDefinitionCache();

        internal MexcRestClientSpotApiSubAccount(MexcRestClientSpotApi baseClient)
        {
            _baseClient = baseClient;
        }

        /// <inheritdoc />
        public Task<WebCallResult<MexcSubUserAccounts>> GetSubUserAccountsAsync(string? name = null, bool? isFreeze = null, int? page = null, int? limit = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddOptional("subAccount", name);
            parameters.AddOptional("isFreeze", isFreeze);
            parameters.AddOptional("page", page);
            parameters.AddOptional("limit", limit);

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/sub-account/list", MexcExchange.RateLimiter.SpotRest, 1, true);
            return _baseClient.SendAsync<MexcSubUserAccounts>(request, parameters, ct);
        }

        /// <inheritdoc />
        public Task<WebCallResult<MexcUniversalTransferResult>> UniversalTransferAsync(string asset, decimal amount, AccountType fromAccountType, AccountType toAccountType, string? fromAccount = null, string? toAccount = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection()
            {
                {"asset", asset },
                {"amount", amount },
            };
            parameters.AddEnum("fromAccountType", fromAccountType);
            parameters.AddEnum("toAccountType", toAccountType);
            parameters.AddOptional("fromAccount", fromAccount);
            parameters.AddOptional("toAccount", toAccount);

            var request = _definitions.GetOrCreate(HttpMethod.Post, "/api/v3/capital/sub-account/universalTransfer", MexcExchange.RateLimiter.SpotRest, 1, true);
            return _baseClient.SendAsync<MexcUniversalTransferResult>(request, parameters, ct);
        }

        /// <inheritdoc />
        public Task<WebCallResult<MexcUniversalTransferPaged>> GetUniversalTransfersAsync(AccountType fromAccountType, AccountType toAccountType, string? fromAccount = null, string? toAccount = null, DateTime? startTime = null, DateTime? endTime = null, int? page = null, int? limit = null, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection();
            parameters.AddEnum("fromAccountType", fromAccountType);
            parameters.AddEnum("toAccountType", toAccountType);
            parameters.AddOptional("fromAccount", fromAccount);
            parameters.AddOptional("toAccount", toAccount);
            parameters.AddOptionalMillisecondsString("startTime", startTime);
            parameters.AddOptionalMillisecondsString("endTime", endTime);
            parameters.AddOptional("page", page);
            parameters.AddOptional("limit", limit);
            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/capital/sub-account/universalTransfer", MexcExchange.RateLimiter.SpotRest, 1, true);
            return _baseClient.SendAsync<MexcUniversalTransferPaged>(request, parameters, ct);
        }

        /// <inheritdoc />
        public Task<WebCallResult<MexcSubUserAccountApiDetails>> GetSubUserAccountApiDetailsAsync(string subAccount, CancellationToken ct = default)
        {
            var parameters = new ParameterCollection()
            {
                {"subAccount", subAccount},
            };

            var request = _definitions.GetOrCreate(HttpMethod.Get, "/api/v3/sub-account/apiKey", MexcExchange.RateLimiter.SpotRest, 1, true, parameterPosition: HttpMethodParameterPosition.InUri);
            return _baseClient.SendAsync<MexcSubUserAccountApiDetails>(request, parameters, ct);
        }
    }
}
