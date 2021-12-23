using System.ComponentModel;

namespace AMcore.Models.Enums
{
    /// <summary>
    /// Состояние подключения к УТМ
    /// </summary>
    public enum UTMConnectionState
    {
        /// <summary>
        /// Не определено
        /// </summary>
        [Description("Не определено")]
        Unknown = 0,
        /// <summary>
        /// Обновляется
        /// </summary>
        [Description("Обновляется")]
        Updating = 1,
        /// <summary>
        /// Установлено
        /// </summary>
        [Description("Установлено")]
        Established = 2,
        /// <summary>
        /// Установлено
        /// </summary>
        [Description("Не доступно")]
        NotAvailable = 3
    }
}
