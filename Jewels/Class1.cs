using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewels
{
    public class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis) {
            Console.WriteLine("To jest klasa bazowa: " + baseClassNeedsThis);
        }
    }
    public class MySubClass : MyBaseClass {
        public MySubClass(string baseClassNeedsThis,int anotherValue): base(baseClassNeedsThis)
        {
            Console.WriteLine("To jest klasa bazowa: " + baseClassNeedsThis + " i " + anotherValue);
        }
        
    }
}
