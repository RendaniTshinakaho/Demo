namespace Error_Handling
{
   public class Car
   {
       private string _make;
       private string _model;
       private int _elapseMileage;
       //
       public Car()
       {
           
       }
       public Car(string Make,string Model,int ElapseMileage)
       {
           _make = Make;
           _model = Model;
           _elapseMileage = ElapseMileage;
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
           set {
               if (value > 0)
               {
                   _elapseMileage = value;
               }
           }
       }
   }
}
