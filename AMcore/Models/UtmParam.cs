using AMcore.Extensions;
using AMcore.Models.Enums;

namespace AMcore.Models
{
    public class UtmParam
    {
        private string _fsrarID = string.Empty;

        public UtmParam() { }
        public UtmParam(string fsrarID, string connectionAddress, int connectionPort)
        {
            _fsrarID = fsrarID;
            SetConnectionString(connectionAddress, connectionPort);
        }
        #region Public Properties
        /// <summary>
        /// FSRAR ID
        /// </summary>
        public string FSRARID
        {
            get => _fsrarID; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Пустое значение ФСРАР ID");
                if (value.Length != 12)
                    throw new ArgumentException($"Не корректная длинна ФСРАР ID. Значение: {value}");
                if (value.Any(c => !char.IsDigit(c)))
                    throw new ArgumentException($"ФСРАР ID содержит не допустимые символы. Значение: {value}");
                _fsrarID=value;
            }
        }
        /// <summary>
        /// Полный адрес УТМ
        /// </summary>
        public string ConnectionString => $"{ConnectionHost}:{ConnectionPort}";
        /// <summary>
        /// Хост
        /// </summary>
        public string? ConnectionHost { private set; get; }
        /// <summary>
        /// Порт
        /// </summary>
        public int ConnectionPort { private set; get; }
        /// <summary>
        /// Наименование организации
        /// </summary>
        public string? CompanyName { set; get; }
        /// <summary>
        /// Состояние соединения с УТМ
        /// </summary>
        public UTMConnectionState UTMConnectionState { set; get; } = UTMConnectionState.Unknown;
        /// <summary>
        /// Понятное описание текущего состояния.
        /// </summary>
        public string DescriptionConnectionState => this.UTMConnectionState.GetEnumDescription();
        /// <summary>
        /// Описание ошибки подключения.
        /// </summary>
        public string? ConnectionStateErrorDetails { set; get; }
        /// <summary>
        /// Версия УТМ
        /// </summary>
        public string? Version { get; set; }
        #endregion


        /// <summary>
        /// Установить Адрес УТМ
        /// </summary>
        public void SetConnectionString(string connectionAddress, int connectionPort)
        {
            if (string.IsNullOrWhiteSpace(connectionAddress))
                throw new ArgumentException($"\"{nameof(connectionAddress)}\" не может быть пустым или содержать только пробел.", nameof(connectionAddress));
            if (connectionPort < 0 || connectionPort > 65535)
                throw new ArgumentException($"Не допустимая строка подключения.");
            ConnectionHost = connectionAddress;
            ConnectionPort = connectionPort;
        }
    }
}
