using AMcore.Models.Enums;
using Newtonsoft.Json;

namespace AMcore.Models.EGAIS
{
    /// <summary>
    /// Информация о сертификате
    /// </summary>
    public partial class Сertificate
    {
        /// <summary>
        /// Тип сертификата
        /// </summary>
        [JsonProperty("certType")]
        public CertType CertType { get; set; }
        /// <summary>
        /// Дата начала срока действия
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Дата истечения срока действия
        /// </summary>
        [JsonProperty("expireDate")]
        public DateTime ExpireDate { get; set; }
        /// <summary>
        /// Валидность
        /// </summary>
        [JsonProperty("isValid")]
        public string? IsValid { get; set; }
        /// <summary>
        /// Издатель
        /// </summary>
        [JsonProperty("issuer")]
        public string? Issuer { get; set; }
    }
}
