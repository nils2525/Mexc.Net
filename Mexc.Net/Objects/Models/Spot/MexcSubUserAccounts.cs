namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Sub accounts info
    /// </summary>
    public class MexcSubUserAccounts
    {
        /// <summary>
        /// Sub accounts
        /// </summary>
        [JsonPropertyName("subAccounts")]
        public MexcSubUserAccount[] SubAccounts { get; set; } = Array.Empty<MexcSubUserAccount>();
    }
}
