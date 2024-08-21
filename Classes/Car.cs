namespace Classes;

public class Car
{
    
 
    
    
    //properties of a car
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }


    public void Type()
    {
        Console.WriteLine($"The Car i have is a {Year} {Make} {Model}.");
        Console.WriteLine("-------------------------------------------");
    }
    
    
}