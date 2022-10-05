using System;

namespace lr3_3
{
    class Currency
    {
        public double Value;
    }
    class CurrencyUSD : Currency
    {
        static public double ieur=8;
        static public double irub=5;

        public CurrencyUSD(double val)
        {
            this.Value = val;
        }

        public static explicit operator CurrencyUSD(CurrencyEUR eur)
        {
            return new CurrencyUSD(eur.Value * ieur);
        }
        public static explicit operator CurrencyUSD(CurrencyRUB rub)
        {
            return new CurrencyUSD(rub.Value * irub);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    class CurrencyEUR : Currency
    {
        static public double iirub=3;
        static public double iusd=2;
        public CurrencyEUR(double val)
        {
            this.Value = val;
        }
        public static explicit operator CurrencyEUR(CurrencyUSD usd)
        {
            return new CurrencyEUR(usd.Value * iusd);
        }
        public static explicit operator CurrencyEUR(CurrencyRUB rub)
        {
            return new CurrencyEUR(rub.Value * iirub);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    class CurrencyRUB: Currency
    {
        static public double iieur=9;
        static public double iiusd=7;
        public CurrencyRUB(double val)
        {
            this.Value = val;
        }
        public static explicit operator CurrencyRUB(CurrencyEUR eur)
        {
            return new CurrencyRUB(eur.Value * iieur);
        }
        public static explicit operator CurrencyRUB(CurrencyUSD usd)
        {
            return new CurrencyRUB(usd.Value * iiusd);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double money = 100;
            Console.WriteLine($"rub: {money}");
            CurrencyRUB money_rub = new CurrencyRUB(money);
            CurrencyUSD money_usd = (CurrencyUSD)money_rub;
            CurrencyEUR money_eur = (CurrencyEUR)money_rub;
            Console.WriteLine($"usd: {money_usd}");
            Console.WriteLine($"eur: {money_eur}");
        }
    }
}
