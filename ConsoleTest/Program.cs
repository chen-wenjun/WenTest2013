using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleTest
{
    public struct MyStruct
    {
        public List<int> List;
    }

    //[Flags]
    //public enum TaxProviderType
    //{
    //    None = 0,

    //    Mosaic = 1,

    //    Avalara = 2,

    //    Vertex = 4
    //}


    public enum TaxProviderType
    {
        None = 0,

        Mosaic = 1,

        Avalara = 2,

        Vertex = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            {
                int a0 = 1 << 0;
                int a1 = 1 << 1;
                int a2 = 1 << 2;
                int a3 = 1 << 3;
                int a4 = 1 << 4;

            }

            {
                //TaxProviderType provider;
                //Enum.TryParse<TaxProviderType>("Vertex,  Avalara", out provider);

                TaxProviderType provider = TaxProviderType.Avalara | TaxProviderType.Vertex;

                if((provider & TaxProviderType.Avalara) == TaxProviderType.Avalara)
                {
                    ;
                }
                
                if((provider & TaxProviderType.Vertex) == TaxProviderType.Vertex)
                {
                    ;
                }

                if ((provider & TaxProviderType.Mosaic) == TaxProviderType.Mosaic)
                {
                    ;
                }


            }

            {
                string value = "BAD";
                string s1 = Regex.Replace(value, "([a-z])([A-Z])", "$1 $2");
            }

            {
                int? a = new int?();
                a = false ? 10 : new int();
            }

            {
                decimal taxAmount = 12.23M;
                taxAmount = (Math.Truncate(taxAmount * Convert.ToDecimal(Math.Pow(10.0, 2))) + 1) / Convert.ToDecimal(Math.Pow(10.0, 2));
            }

            {
                decimal result2 = Math.Round(12.245M, 2, MidpointRounding.AwayFromZero);
                decimal result3 = Math.Round(12.245M, 2, MidpointRounding.ToEven);

                decimal result10 = Math.Truncate(12.987M);
            }

            {
                decimal a = 11.238678M;

                int decimals = 2;
                decimal mask = 1M / ((decimal)Math.Pow(10, decimals));
                decimal remainder = a % mask;
                var result1 = a - a % mask;


            }

            {
                int? a = null;
                int? b = null;

                bool equ = a == b;
                bool nequ = a != b;
            }

            {
                try
                {
                    Exception ex = new Exception();
                    ex.Data.Add("key1", "value1");
                    ex.Data.Add("key2", "value2");
                    ex.Data.Add("key3", "value3");

                    throw ex;
                }
                catch (Exception ex)
                {
                    
                    throw;
                }
            }

            {
                string group = "cn=DevelopmentCN=,OU=Raymark Groups,DC=raymarkx,DC=raymarkx,DC=com";

                string[] pieces = group.Split(',');
                string groupPiece = pieces[0].Trim();
                if (groupPiece.StartsWith("CN=", StringComparison.OrdinalIgnoreCase))
                    groupPiece = groupPiece.Substring(3);

            }

            {
                int[] items = new int[10];
                for (int i = 0; i < 10; i++)
                    items[i] = i;

                CircularArray<int> circular = new CircularArray<int>(items);

                circular.Print();
                circular.Rotate(-1);
                circular.Print();

                int item = circular[0];


                circular.Rotate(9);
                circular.Print();
                circular.Rotate(1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();
                circular.Rotate(-1);
                circular.Print();


            }




            MyStruct myStruct = new MyStruct();
            myStruct.List = new List<int>();

            int number = NumberOfList(myStruct);




            string t = DateTime.Now.ToString("HH:mm");

            int n = 16;
            int resul = SumOfPowerFortwo(n);
            int resul1 = (int)Math.Pow(2, n + 1) - 1;

            double re = Math.Pow(9, 1 / 2.0);
            double re1 = Math.Sqrt(9);


            List<int> l1 = new List<int>();
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);

            List<int> l2 = l1;
            l2.Add(4);



            SortedList<int, string> slist = new SortedList<int, string>();
            slist.Add(3, "3");
            slist.Add(2, "2");
            slist.Add(1, "1");
            slist.Add(4, "4");



            string inputString = @"2016-02-15T18:18:18";
            string pattern = @"[+-]\d\d:\d\d$";
            Regex regex = new Regex(pattern);

            string absoluteTimeWithoutTimezone = regex.Replace(inputString, string.Empty);

            DateTime absoluteTime = JsonConvert.DeserializeObject<DateTime>(string.Format("\"{0}\"", absoluteTimeWithoutTimezone));
            DateTime resultDateTime = DateTime.SpecifyKind(absoluteTime, DateTimeKind.Local);


            //TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Australia/Lord_Howe");
            TimeSpan span = TimeZoneInfo.Local.GetUtcOffset(DateTime.Now);
            TimeSpan span1 = TimeZoneInfo.Local.GetUtcOffset(new DateTime(2016, 7, 1, 0, 0, 0, DateTimeKind.Local));



            DateTime dateUtc = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime dateLocal = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Local);
            DateTime dateUnspecified = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified);

            DateTime now = DateTime.Now;
            DateTime min = DateTime.MinValue;
            DateTime max = DateTime.MaxValue;
            DateTime utcNow = DateTime.UtcNow;
            DateTime today = DateTime.Today;


            DateTimeOffset offsetNow = DateTimeOffset.Now;
            DateTimeOffset offsetUtcNow = DateTimeOffset.UtcNow;
            DateTimeOffset offset = new DateTimeOffset(2017, 02, 10, 14, 33, 42, 123, TimeSpan.FromHours(-2));




        }

        static int NumberOfList(MyStruct myStruct)
        {
            //if (myStruct.List.Count > 10)
            //    return myStruct.List.Count;

            myStruct.List.Add(1);

            return myStruct.List.Count;
        }

        static int SumOfPowerFortwo(int n)
        {
            if (n < 0)
                return 0;
            else
            {
                return (int)Math.Pow(2, n) + SumOfPowerFortwo(n - 1);
            }
        }
    }

}
