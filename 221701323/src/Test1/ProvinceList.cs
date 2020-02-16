using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class ProvinceList
    {
        string[] CityList ={
                "安徽","北京","重庆","福建","甘肃","广东","广西","贵州","海南","河北","河南","黑龙江","湖北",
                "湖南","吉林","江苏","江西","辽宁","内蒙古","宁夏","青海","山东","山西","陕西","上海","四川",
                "天津","西藏","新疆","云南","浙江","全国"
            };
        public ArrayList Provinces=new ArrayList();
        public ProvinceList(string[] citys)
        {
            if (citys != null)
            {
                CityList = citys;
            }
            else
            {
                Console.WriteLine("citys为空");
            }
            foreach (string city in CityList)
            {
                Provinces.Add(new Province(city));
            }
        }

    }
}
