namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Lexus";
            myCar.Model = "RX350";
            myCar.Year = 2015;

            myCar.Type();


            var brothersCar = new Car()
            {
                Make = "Nissan",
                Model = "Rogue",
                Year = 2019
            };

            brothersCar.Type();






        }

         
    }
}
