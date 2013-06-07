using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
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
               if ((value!= "Oldmobile") && (value!="Chevrolet"))
               {
                   _make = string.Empty;
               }
               _make = value;
           }
       }
   }
}
