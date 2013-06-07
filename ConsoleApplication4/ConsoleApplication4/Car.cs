namespace ConsoleApplication4
{
   public class Car
   {
       private int _elapseMileage;
       //
       public Car(string Make,string Model,int ElapseMileage)
       {
           this.Make = Make;
           this.Model = Model;
           _elapseMileage = ElapseMileage;
       }

       public string Make { get; set; }

       public string Model { get; set; }

       public int ElapseMileage
       {
           get { return _elapseMileage; }
           set
           {
               if (value > 0)
                   _elapseMileage = value;
           }
       }
   }
}
