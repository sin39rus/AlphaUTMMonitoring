using Newtonsoft.Json;

namespace AMcore.Models.EGAIS
{
    /// <summary>
    /// Информация об организации
    /// </summary>
    public class OrgInfo
    {
        /// <summary>
        /// Код страны
        /// </summary>
        [JsonProperty("c")]
        public string? C { get; set; }
        /// <summary>
        /// Нименование юридического лица
        /// </summary>
        [JsonProperty("cn")]
        public string? CN { get; set; }
        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        [JsonProperty("emailaddress")]
        public string? Emailaddress { get; set; }

        [JsonProperty("from")]
        public string? From { get; set; }
        /// <summary>
        /// Имя Отчетсво владельца
        /// </summary>
        [JsonProperty("givenname")]
        public string? Givenname { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        [JsonProperty("inn")]
        public string? INN { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        [JsonProperty("kpp")]
        public string? KPP { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        [JsonProperty("l")]
        public string? L { get; set; }
        /// <summary>
        /// Наименование ЮЛ
        /// </summary>
        [JsonProperty("o")]
        public string? O { get; set; }
        /// <summary>
        /// ОГРН
        /// </summary>
        [JsonProperty("ogrn")]
        public string? OGRN { get; set; }

        [JsonProperty("ou")]
        public string? Ou { get; set; }
        /// <summary>
        /// Серийный номер
        /// </summary>
        [JsonProperty("serial")]
        public string? Serial { get; set; }
        /// <summary>
        /// СНИЛС
        /// </summary>
        [JsonProperty("snils")]
        public string? SNILS { get; set; }
        /// <summary>
        /// Регион
        /// </summary>
        [JsonProperty("st")]
        public string? St { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        [JsonProperty("street")]
        public string? Street { get; set; }
        /// <summary>
        /// Фамилия владельца
        /// </summary>
        [JsonProperty("surname")]
        public string? Surname { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        [JsonProperty("t")]
        public string? T { get; set; }

        [JsonProperty("to")]
        public string? To { get; set; }

        public static OrgInfo Parse(string data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));
            OrgInfo? orgInfo = JsonConvert.DeserializeObject<OrgInfo>(data);
            if (orgInfo == null)
                throw new ArgumentException("Ошибка получания данных организации.");
            return orgInfo;
        }
    }
}
