using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class BuildingInfoAttribute:Attribute
    {
        public string name;
        public string nameOrg;
        public BuildingInfoAttribute(string name, string nameOrg)
        {
            this.name = name;
            this.nameOrg = nameOrg;  
        }
    }
}
