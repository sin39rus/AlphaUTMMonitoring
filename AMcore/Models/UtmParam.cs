using AMcore.Extensions;
using AMcore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AMcore.Models
{
    public class UtmParam
    {
        private string fsrarID = string.Empty;
        private int connectionPort;

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

        private string connectionString;
        private readonly string descriptionConnectionState;

        /// <summary>
        /// Адрес УТМ
        /// </summary>
        public string ConnectionString { get => connectionString; private set => connectionString = value; }

        /// <summary>
        /// Адрес УТМ
        /// </summary>
        public void SetConnectionString(string connectionAddress, int connectionPort)
        {
            if (!IPEndPoint.TryParse($"{connectionAddress}:{connectionPort}", out IPEndPoint ip))
                throw new ArgumentException($"Не допустимая строка подключения;");
            connectionString=$"{connectionAddress}:{connectionPort}";
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
