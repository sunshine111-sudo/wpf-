using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 证券交易系统2
{ }
   /* class Gpsearch
    {
        public async Task<StockInfo> GetCurrentPriceAsync(StockInfo Share)
        {
            try
            {
                string apiurl = "http://hq.sinajs.cn/list=";
                string code = "";
                if (Share.ShareType == ShareType.sh)
                {
                    code = "sh" + Share.ShareCode;
                }
                else
                {
                    code = "sz" + Share.ShareCode;
                }
                apiurl = apiurl + code;
                WebClient client = new WebClient()
                {

                };
                string str = await client.DownloadStringTaskAsync(apiurl);

                string[] sArray = str.Split(',');
                Share.ShareName = sArray[0].Replace($"var hq_str_{code}=\"", "");
                Share.YesterdayPrice = sArray[2];
                Share.CurrentPrice = sArray[3];

            }
            catch (Exception)
            {


            }
            return Share;

        }
    }
}
*/