using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    class Type
    {
        string TypeName;
        string ShortName;
        public Type(string fullname,string shortname)
        {
            TypeName = fullname;
            ShortName = shortname;
        }
        public string Name
        {
            get
            {
                return TypeName;
            }
        }
        public string Short
        {
            get
            {
                return ShortName;
            }
        }

    }
}
