using Newtonsoft.Json;

namespace AMcore.Models.EGAIS
{
    /// <summary>
    /// Информация о состоянии УТМ
    /// </summary>
    public partial class UtmInfo
    {
        /// <summary>
        /// Версия УТМ
        /// </summary>
        [JsonProperty("version")]
        public string? Version { get; set; }
        /// <summary>
        /// Рабочий контур
        /// <para>Продуктивный контур/Тестовый контур</para>
        /// </summary>
        [JsonProperty("contour")]
        public string? Contour { get; set; }
        /// <summary>
        /// Ошибки сертификата RSA
        /// </summary>
        [JsonProperty("rsaError")]
        public object? RsaError { get; set; }
        /// <summary>
        /// Чего-то инфо, не понял.
        /// </summary>
        [JsonProperty("checkInfo")]
        public object? CheckInfo { get; set; }
        /// <summary>
        /// ФСРАР ID Собственника сертификата
        /// </summary>
        [JsonProperty("ownerId")]
        public string? OwnerId { get; set; }
        /// <summary>
        /// Информация о базе данных УТМ
        /// </summary>
        [JsonProperty("db")]
        public DbInfo? Db { get; set; }
        /// <summary>
        /// Информация о сертификате RSA
        /// </summary>
        [JsonProperty("rsa")]
        public Сertificate? Rsa { get; set; }
        /// <summary>
        /// Информация о сертификате ГОСТ
        /// </summary>
        [JsonProperty("gost")]
        public Сertificate? Gost { get; set; }
        /// <summary>
        /// Признак действующей лицензии
        /// </summary>
        [JsonProperty("license")]
        public bool License { get; set; }

        public static UtmInfo Parse(string data)
        {
            if(data == null)
                throw new ArgumentNullException(nameof(data));
            UtmInfo? utmInfo = JsonConvert.DeserializeObject<UtmInfo>(data);
            if(utmInfo == null)
                throw new ArgumentException("Ошибка получения информации об УТМ.");
            return utmInfo;
        }
    }
}
