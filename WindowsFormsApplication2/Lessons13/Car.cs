using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons13
{
  public class Car
  {
      private string _make;
      private string _model;
      private int _elapseMileage;
      public Car()
      {
          //Add Constructor Logic here,can connect to a database :()
          //setup initial values for the fields,Open up a file in a hard drive,
          _make = "DEFAULT";
          _model = "DEFAULT";
          _elapseMileage = 10000;
      }
      public Car(string make,string model,int elapseMileage)
      {
          _make = make;
          _model = model;
          _elapseMileage = elapseMileage;
          MessageBox.Show("Overloaded Constructors");
      }
      public string Make
      {
          get { return _make; }
          set { _make = value; }
      }
      public string Model
      {
          get { return _model; }
          set { _model = value; }
      }
      public int ElapseMileage
      {
          get { return _elapseMileage; }
          set { if (value > 0) _elapseMileage = value; }
      }
      ~Car()
      {
          //Save the values of car in the database
          //Close Files
          MessageBox.Show("Called Destructor");
      }
  }

}
