namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Sub user account api detail
    /// </summary>
    public class MexcSubUserAccountApiDetail
    {
        /// <summary>
        /// Note
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Api key
        /// </summary>
        [JsonPropertyName("apikey")]
        public string ApiKey { get; set; } = string.Empty;
        
        /// <summary>
        /// Creation time
        /// </summary>
        [JsonPropertyName("createTime")]
        public DateTime CreateTime { get; set; }
    }
}
