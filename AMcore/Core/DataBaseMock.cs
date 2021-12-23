using AMcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMcore.Core
{
    public class DataBaseMock : IDataBase
    {
        private readonly List<UtmParam> _utmParams;
        public DataBaseMock()
        {
            _utmParams = new List<UtmParam> {
            new UtmParam("020000030873", "127.0.0.1", 8080),
            new UtmParam("030000012873", "192.168.200.1", 8080),
            new UtmParam("030000012663", "mail.ru", 8080),
            new UtmParam("030020012123", "alpha.ru", 8080) };
        }

        public void AddUtmParam(UtmParam utmParam)
        {
            _utmParams.Add(utmParam);
        }

        public List<UtmParam> GetUtmParams()
        {
            return _utmParams;
        }
    }
}

