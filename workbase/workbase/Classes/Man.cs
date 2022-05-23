using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workbase.Classes
{
    public class Man
    {
        const int l_name = 30;
        string name;
        int birth_year;
        double pay;
        public Man()
        {
            name = "Anonymous";
            birth_year = 0;
            pay = 0;
        }
        public Man(string s)
        {
            name = s.Substring(0, l_name);
            birth_year = Convert.ToInt32(s.Substring(l_name, 4));
            pay = Convert.ToDouble(s.Substring(l_name + 4));
            if (birth_year < 0) throw new FormatException();
            if (pay < 0) throw new FormatException();
        }
        public override string ToString()
        {
            return string.Format("Name: {0,30} birth: {1} pay: {2:F2}", name, birth_year, pay);
        }
        public int Compare(string name)
        {
            return (string.Compare(this.name, 0, name + " ", 0, name.Length + 1, StringComparison.OrdinalIgnoreCase));
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Birth_year
        {
            get { return birth_year; }
            set 
            {
                if (value > 0) birth_year = value;
                else throw new FormatException();
            }
        }
        public double Pay
        {
            get { return pay; }
            set
            {
                if (value > 0) pay = value;
                else throw new FormatException();
            }
        }
        public static double operator +(Man man1, double a)
        {
            man1.pay += a;
            return man1.pay;
        }
        public static double operator +(double a, Man man1)
        {
            man1.pay += a;
            return man1.pay;
        }
        public static double operator -(Man man1, double a)
        {
            man1.pay -= a;
            if (man1.pay < 0) throw new FormatException();
            return man1.pay;
        }
    }
}
