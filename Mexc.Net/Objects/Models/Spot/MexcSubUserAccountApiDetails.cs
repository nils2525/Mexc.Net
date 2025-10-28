namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Sub user account api details
    /// </summary>
    public class MexcSubUserAccountApiDetails
    {
        /// <summary>
        /// API keys details
        /// </summary>
        [JsonPropertyName("subAccount")]
        public MexcSubUserAccountApiDetail[] Keys { get; set; } = [];
    }
}
