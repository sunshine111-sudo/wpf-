using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 证券交易系统2
{
    public class StockInfo
    {
        public String name { get; set; }//名字
        public String code { get; set; }//股票代码
        public DateTime date { get; set; }//时间
        public double open { get; set; }//开盘价
        public double high { get; set; }//最高价 
        public double low { get; set; }//最低价 
        public double close { get; set; }//收盘价   
        public double volume { get; set; }//成交量

    }
}
