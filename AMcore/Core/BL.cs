using AMcore.Helpers;
using AMcore.Models;
using AMcore.Models.EGAIS;
using AMcore.Models.Enums;
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

        public static async Task GetOrRefreshUtmStateAsync(UtmParam utmParam)
        {
            try
            {
                utmParam.UTMConnectionState = UTMConnectionState.Updating;
                string infoResponse = await WebClient.WebGetAsync("http://" + utmParam.ConnectionString + "/api/info/list");
                string versionResponse = await WebClient.WebGetAsync("http://" + utmParam.ConnectionString + "/info/version");
                string orgInfoResponse = await WebClient.WebGetAsync("http://" + utmParam.ConnectionString + "/api/gost/orginfo");
                UtmInfo utmInfo = UtmInfo.Parse(infoResponse);
                OrgInfo orgInfo = OrgInfo.Parse(orgInfoResponse);

                utmParam.UTMConnectionState = UTMConnectionState.Established;
                utmParam.FSRARID = utmInfo.OwnerId;
                utmParam.Version = versionResponse;
                utmParam.CompanyName = orgInfo.CN;
            }
            catch (Exception ex)
            {
                utmParam.UTMConnectionState = UTMConnectionState.NotAvailable;
                utmParam.ConnectionStateErrorDetails = ex.Message;
            }
        }
    }
}
