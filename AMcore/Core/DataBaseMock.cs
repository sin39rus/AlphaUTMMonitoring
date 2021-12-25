using AMcore.Models;

namespace AMcore.Core
{
    public class DataBaseMock : IDataBase
    {
        private readonly List<UtmParam> _utmParams = new();
        public DataBaseMock()
        {
            //_utmParams = new List<UtmParam> {
            //new UtmParam("030000647619", "192.168.210.11", 8081),
            //new UtmParam("030000578676", "192.168.210.12", 8080),
            //new UtmParam("030000628782", "192.168.210.24", 8081),
            //new UtmParam("030000252135", "78.36.203.126", 53232),
            //new UtmParam("030000647619", "192.168.210.11", 8081),
            //new UtmParam("030000578676", "192.168.210.12", 8081),
            //new UtmParam("030000628782", "192.168.210.24", 8081),
            //new UtmParam("030000252135", "78.36.203.126", 53233) };


            for (int x = 53200; x <= 53312; x++)
                _utmParams.Add(new UtmParam("030000252135", "78.36.203.126", x));
            for (int x = 2; x <= 30; x++)
                _utmParams.Add(new UtmParam("030000252135", $"192.168.210.{x}", 8080));
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

