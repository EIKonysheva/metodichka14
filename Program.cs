
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(23);
            bank.DumpToScreen();
            System.Reflection.MemberInfo typeInfo;
            typeInfo = typeof(Building);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            foreach (Attribute atr in attrs)
            {
                if (atr is BuildingInfoAttribute)
                {
                    BuildingInfoAttribute info = (BuildingInfoAttribute)atr;
                    Console.WriteLine( info.name +"\n"+ info.nameOrg);
                }
            } 
        }
    }
}
