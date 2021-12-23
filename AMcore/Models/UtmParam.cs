using AMcore.Extensions;
using AMcore.Models.Enums;
using System.Net;

namespace AMcore.Models
{
    public class UtmParam
    {
        private string fsrarID = string.Empty;

        public UtmParam() { }
        public UtmParam(string fsrarID, string connectionAddress, int connectionPort)
        {
            FSRARID=fsrarID;
            SetConnectionString(connectionAddress, connectionPort);
        }

        /// <summary>
        /// FSRAR ID
        /// </summary>
        public string FSRARID
        {
            get => fsrarID; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Пустое значение ФСРАР ID");
                if (value.Length != 12)
                    throw new ArgumentException($"Не корректная длинна ФСРАР ID. Значение: {value}");
                if (value.Any(c => !char.IsDigit(c)))
                    throw new ArgumentException($"ФСРАР ID содержит не допустимые символы. Значение: {value}");
                fsrarID=value;
            }
        }


        /// <summary>
        /// Адрес УТМ
        /// </summary>
        public string ConnectionString => $"{ConnectionAddress}:{ConnectionPort}";
        /// <summary>
        /// Адрес
        /// </summary>
        public string? ConnectionAddress { private set; get; }
        /// <summary>
        /// Порт
        /// </summary>
        public int ConnectionPort { private set; get; }

        /// <summary>
        /// Адрес УТМ
        /// </summary>
        public void SetConnectionString(string connectionAddress, int connectionPort)
        {
            if (connectionPort < 0 || connectionPort > 65535)
                throw new ArgumentException($"Не допустимая строка подключения.");
            ConnectionAddress = connectionAddress;
            ConnectionPort = connectionPort;
        }
        /// <summary>
        /// Наименование организации
        /// </summary>
        public string? CompanyName { set; get; }
        /// <summary>
        /// Состояние соединения с УТМ
        /// </summary>
        public UTMConnectionState UTMConnectionState { set; get; } = UTMConnectionState.Unknown;
        public string DescriptionConnectionState => this.UTMConnectionState.GetEnumDescription();
    }
}
