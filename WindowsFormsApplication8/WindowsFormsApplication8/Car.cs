using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication8
{
   public class Car
   {
       private string _make;
       private string _model;

       public string Make
       {
           get { return _make; }
           set
           {
               if ((value != "Opel") && (value != "Mercedes"))
                   _make = string.Empty;
               else
               {
                   _make = value;
               }
           }
       }
   }
}
