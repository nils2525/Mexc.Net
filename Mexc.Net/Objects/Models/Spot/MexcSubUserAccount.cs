namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Sub user account info
    /// </summary>
    public class MexcSubUserAccount
    {
        /// <summary>
        /// Sub account name
        /// </summary>
        [JsonPropertyName("subAccount")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Is frozen
        /// </summary>
        [JsonPropertyName("isFreeze")]
        public bool IsFreeze { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonPropertyName("createTime")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreateTime { get; set; }
        
        /// <summary>
        /// Account id
        /// </summary>
        [JsonPropertyName("uid")]
        public long AccountId { get; set; }
    }
}
