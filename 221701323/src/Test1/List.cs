using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class List
    {
        string Log;
        string Out;
        DateTime Date;
        TypeList Types;
        ProvinceList province;
        
        public List(string log,string outd,DateTime nowTime,string[] citys,string[] types) 
        {
            Log = log;
            Out = outd;
            Date =nowTime;
            province = new ProvinceList(citys);
            Types =new TypeList(types);
        }
        public string log
        {
            get
            {
                return Log;
            }
        }
        public string OUT
        {
            get
            {
                return Out;
            }
        }
        public string time
        {
            get
            {
                return Date.ToString("yyyy-MM-dd");
            }
        }
        public void printout()
        {
            Console.WriteLine("log为：" + Log);
            Console.WriteLine("out为：" + Out);
            Console.WriteLine("date为：" + Date.ToString("yyyy-MM-dd"));
            foreach(Province p in province.Provinces)
            {
                Console.WriteLine("城市：" + p.Name);
                if (Types.ht.Contains("ip"))
                {
                    Console.WriteLine("感染患者：" + p.Ip);
                }
                if (Types.ht.Contains("sp"))
                {
                    Console.WriteLine("疑似患者：" + p.Sp);
                }
                if (Types.ht.Contains("dead"))
                {
                    Console.WriteLine("死亡：" + p.Dead);
                }
                if (Types.ht.Contains("cure"))
                {
                    Console.WriteLine("治愈：" + p.Cure);
                }


            }
        }

    }
}
