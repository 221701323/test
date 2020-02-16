using System;
using System.Collections;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string log;
            string outd;
            DateTime Time;
            string[] types=null;
            string[] citys=null;

            log = Console.ReadLine();

            outd = Console.ReadLine();

            string timeString;
            timeString = Console.ReadLine();
            string[] times = timeString.Split('-');
            Time = new DateTime(int.Parse(times[0]), int.Parse(times[1]), int.Parse(times[2]));

            int n;
            ArrayList cs = new ArrayList();
            Console.WriteLine("请输入要输入的城市个数");
            n= int.Parse(Console.ReadLine());
            if (n != 0)
            {
                for(int i = 0; i < n; i++)
                {
                    string name = Console.ReadLine();
                    cs.Add(name);
                }
           
                Object[] turn= cs.ToArray();
                citys = new string[turn.Length];
                for(int i = 0; i < n; i++)
                {
                    citys[i] = turn[i].ToString();
                }
            }
            
            ArrayList ts = new ArrayList();
            Console.WriteLine("请输入要输入的城市个数");
            n = int.Parse(Console.ReadLine());
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    string name = Console.ReadLine();
                    ts.Add(name);
                }

                Object[]  turn = ts.ToArray();
                types = new string[turn.Length];
                for (int i = 0; i < n; i++)
                {
                    types[i] = turn[i].ToString();
                }
            }
            

            List list = new List(log, outd, Time, citys, types);

            list.printout();

        }
    }
}
