namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Paged universal transfer results
    /// </summary>
    public class MexcUniversalTransferPaged
    {
        /// <summary>
        /// Total pages
        /// </summary>
        [JsonPropertyName("totalCount")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Transfers data
        /// </summary>
        [JsonPropertyName("result")]
        public MexcUniversalTransfer[] Data { get; set; } = Array.Empty<MexcUniversalTransfer>();
    }
}
