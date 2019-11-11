using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BaseClass
    {
        public string publicField = "BaseClass.publicField";
        
        protected string protectedField = "BaseClass.protectedField";
        
        private string privateField = "BaseClass.privateField";

        public void MethodFromBase()
        {
            Console.WriteLine(protectedField);
        }

        public string MethodPrivateField()
        {
            return privateField;
        }
      
    }
}
