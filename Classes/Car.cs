namespace Classes;

public class Car
{
    
    //constructors

    public Car()
    {
        
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;

    }
    
    
    
    //properties of a car
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    
    
}