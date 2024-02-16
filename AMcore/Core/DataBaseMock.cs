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
            //new UtmParam("", "78.36.203.126", 53232),
            //new UtmParam("030000647619", "192.168.210.11", 8081),
            //new UtmParam("030000578676", "192.168.210.12", 8081),
            //new UtmParam("030000628782", "192.168.210.24", 8081),
            //new UtmParam("", "78.36.203.126", 53233) };


            //for (int x = 53200; x <= 53312; x++)
                //_utmParams.Add(new UtmParam("", "78.36.203.126", x));
            //for (int x = 20; x <= 110; x++)
                _utmParams.Add(new UtmParam("", $"10.180.180.21", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.22", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.23", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.25", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.26", 8080));
                //_utmParams.Add(new UtmParam("", $"10.180.180.27", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.28", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.29", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.30", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.31", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.32", 8080));

                _utmParams.Add(new UtmParam("", $"10.180.180.41", 8080));
                //_utmParams.Add(new UtmParam("", $"10.180.180.42", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.43", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.44", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.45", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.46", 8080));


                _utmParams.Add(new UtmParam("", $"10.180.180.62", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.64", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.65", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.66", 8080));

                _utmParams.Add(new UtmParam("", $"10.180.180.81", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.83", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.61", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.103", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.24", 8080));

                _utmParams.Add(new UtmParam("", $"10.180.180.101", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.104", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.148", 8080));

                _utmParams.Add(new UtmParam("", $"10.180.180.141", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.86", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.63", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.102", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.106", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.87", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.82", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.142", 8080));

                _utmParams.Add(new UtmParam("", $"10.180.180.84", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.88", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.85", 8080));
                _utmParams.Add(new UtmParam("", $"10.180.180.27", 8080));


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

