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


            var nissan = new Car()
            {
                Make = "Nissan",
                Model = "Rogue",
                Year = 2019
            };
            
            
            var Ford = new Car("Ford", "Mustang", 2024);

            var carList = new List<Car>{myCar, nissan, Ford};

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}, {vehicle.Model}, {vehicle.Year}");
            }
            
            




        }

         
    }
}
