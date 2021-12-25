using Newtonsoft.Json;

namespace AMcore.Models.EGAIS
{
    /// <summary>
    /// Информация о БД УТМ
    /// </summary>
    public partial class DbInfo
    {
        /// <summary>
        /// Дата и время создания БД
        /// </summary>
        [JsonProperty("createDate")]
        public DateTimeOffset? CreateDate { get; set; }
        /// <summary>
        /// ФСРАР ID создателя БД
        /// </summary>
        [JsonProperty("ownerId")]
        public string? OwnerId { get; set; }
    }
}
