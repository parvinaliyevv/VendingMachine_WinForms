using System;

namespace homework
{
    public class BuyInfo
    {
        public BuyInfo(decimal money, double restMoney)
        {
            Money = money;
            RestMoney = restMoney;
        }

        public System.Collections.Generic.List<string> Snacks { get; set; } = new();

        public decimal Money { get; set; }
        public double RestMoney { get; set; }

        public DateTime Time { get; set; } = DateTime.Now;

    }
}
