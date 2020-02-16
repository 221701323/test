using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Province//城市类
    {
        int ip;
        int sp;
        int cure;
        int dead;
        string ProvinceName;

        public Province(string CityName)
        {
            ip = 0;
            sp = 0;
            cure = 0;
            dead = 0;
            ProvinceName = CityName;
        }
        public string Name
        {
            get
            {
                return ProvinceName;
            }
        }
        public int Ip
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
            }
        }
        public int Sp
        {
            get
            {
                return sp;
            }
            set
            {
                sp = value;
            }
        }
        public int Dead
        {
            get
            {
                return dead;
            }
            set
            {
                dead = value;
            }
        }
        public int Cure
        {
            get
            {
                return cure;
            }
            set
            {
                cure = value;
            }
        }


    }
}
