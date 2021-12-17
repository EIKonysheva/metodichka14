using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace metodichka14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] 
    /*Для того чтобы для одного элемента можно было задать несколько
атрибутов, необходимо при объявлении класса атрибута установить параметр
AllowMultiple = true:*/
    public class DeveloperInfoAttribute:Attribute
    {
        string name;
        string date;
        public DeveloperInfoAttribute(string name, string date) 
        {
            this.name = name;
            this.date = date;
        }
    }
   
}
