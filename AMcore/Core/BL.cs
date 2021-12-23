using AMcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMcore.Core
{
    public class BL
    {
        private readonly IDataBase _dataBase;
        private readonly List<UtmParam> _utmParams;
        public BL(IDataBase dataBase)
        {
            _dataBase = dataBase;
            _utmParams = _dataBase.GetUtmParams();
        }
        public List<UtmParam> UtmParams => _utmParams;

        public void AddUtmParam (UtmParam utmParam)
        {
            _dataBase.AddUtmParam(utmParam);
        }
    }
}
