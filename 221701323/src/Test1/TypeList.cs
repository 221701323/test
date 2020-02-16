using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class TypeList
    {
        public Hashtable ht = new Hashtable();
        public TypeList(string[] list)
        {
            ht.Add("ip", "感染患者");
            ht.Add("sp", "疑似患者");
            ht.Add("cure", "治愈");
            ht.Add("dead", "死亡");
            Hashtable ht1 = new Hashtable();
            if (list != null)
            {
                foreach (string str in list)
                {
                    ht1.Add(str, ht[str].ToString());
                }
                ht = ht1;
            }
                
            
            else
                Console.WriteLine("types为空");
            
        }
    }
}
