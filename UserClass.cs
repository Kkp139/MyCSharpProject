using System;

public interface ICarFeatures
{
    void StartEngine();
    void StopEngine();
    void PlayRadio();
    void ApplyBrakes();
}

class Car
{
    protected bool hasSunroof, hasAC, hasBackWiper;
    protected string? companyName, model; //fuelType
    protected int year;
    protected double currentSpeed;
    protected int currentGear;

    public bool HasBackWiper { get; set; }
    public bool HasAC { get; set; }
    public virtual bool HasSunroof { get; set; }
    public string CompanyName { get { return companyName; } 
        set
        {
            if ("" == value) throw new ApplicationException("Incorrect input");
            companyName = value;
        }
    }
    public string Model
    {
        get { return model; }
        set
        {
            if ("" == value) throw new ApplicationException("Incorrect input");
            model = value;
        }
    }
    public int Year { get; set; }
    public double FuelEfficiency { get; set; } // in km/l
    public double FuelTankCapacity { get; set; } // in liters
    public double CurrentFuelLevel { get; set; } // in liters
    public Colour CarColour { get; set; }
    public Seater SeatingCapacity { get; set; }
    public FuelType Fuel { get; set; }
    public PowerWindow NumberOfPowerWindows { get; set; }


    // public string FuelType { get; set; }

    public Car(string companyName, string model, int year, bool hasSunroof, bool hasAC, bool hasBackWiper, Colour colour, Seater seater, FuelType fuelType, PowerWindow powerWindow, double fuelEfficiency, double fuelTankCapacity)
    {
        CompanyName = companyName;
        Model = model;
        Year = year;
        HasSunroof = hasSunroof;
        HasAC = hasAC;
        HasBackWiper = hasBackWiper;
        CarColour = colour;
        SeatingCapacity = seater;
        Fuel = fuelType;
        NumberOfPowerWindows = powerWindow;
        FuelEfficiency = fuelEfficiency;
        FuelTankCapacity = fuelTankCapacity;
        CurrentFuelLevel = fuelTankCapacity; // Assuming a full tank at the start
        currentSpeed = 0;
        currentGear = 0;

    }

    public virtual void DisplayCarDetails()
    {
        Console.WriteLine($"Company Name: {CompanyName}, Model: {Model}, Year: {Year}, Sunroof: {HasSunroof}, AC: {HasAC}, BackWiper: {HasBackWiper}, Colour: {CarColour}, Seating Capacity: {SeatingCapacity}, Fuel Type: {Fuel}, Power Windows: {NumberOfPowerWindows}, Fuel Efficiency: {FuelEfficiency} km/l, Fuel Tank Capacity: {FuelTankCapacity} liters ");
    }
    //public void DisplayUserOption()
    //{
    //    Console.WriteLine("Following colours are available :- ");
    //    foreach (Colour clr in Enum.GetValues(typeof(Colour)))
    //    {
    //        Console.WriteLine(clr);
    //    }
    //    Console.WriteLine();

    //    Console.WriteLine("Seating capacity this car following varients are available :- ");
    //    foreach (Seater seat in Enum.GetValues(typeof(Seater)))
    //    {
    //        Console.WriteLine(seat);
    //    }
    //    Console.WriteLine();

    //    Console.WriteLine("Following Fuel types cars are available :- ");
    //    foreach (FuelType fuel in Enum.GetValues(typeof(FuelType)))
    //    {
    //        Console.WriteLine(fuel);
    //    }
    //    Console.WriteLine();

    //    Console.WriteLine("How many power windows you want ? :- ");
    //    foreach (PowerWindow pwindow in Enum.GetValues(typeof(PowerWindow)))
    //    {
    //        Console.WriteLine(pwindow);
    //    }


    //}
    public enum Colour
    {
        RED, GREEN, BLUE, BLACK, WHITE, GREY
    }

    public enum Seater
    {
        TWO, FOUR, FIVE, SEVEN
    }

    public enum FuelType
    {
        PETROL, DIESEL, CNG, CNG_PETROL, CNG_DIESEL, ELECTRIC
    }

    public enum PowerWindow
    {
        ONE, TWO, FOUR
    }

    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }

    public void PlayRadio()
    {
        Console.WriteLine("Radio is playing music.");
    }

    public void Accelerate(double speedIncrease)
    {
        currentSpeed += speedIncrease;
        Console.WriteLine($"Car accelerated to {currentSpeed} km/h");
    }

    public void ApplyBrakes()
    {
        currentSpeed = 0;
        Console.WriteLine("Brakes applied. Car stopped.");
    }

    public int ShiftGear(int newGear)
    {
        if (newGear < 1 || newGear > 5)
        {
            throw new ArgumentException("Invalid gear value.");
        }
        currentGear = newGear;
        Console.WriteLine($"Shifted to gear {currentGear}");
        return currentGear;
    }
    public int ShiftGear(int x, double y) // y = Speed , x = gear
    {
        switch (x)
        {
            case 1:
                if (y <= 10)
                    return 1;
                else
                    return 2;
            case 2:
                if (y <= 20 )
                    return 2;
                else
                    return 3;
            case 3:
                if (y <= 30)
                    return 3;
                else
                    return 4;
            case 4:
                if (y <= 50)
                    return 4;
                else
                    return 5;
            case 5:
                if (y <= 50)
                    return 4;
                else
                    return 5;
            default:
                throw new ArgumentException("Invalid gear value.");
        }

    }

    public void CalculateFuelConsumption(double distance)
    {
        double fuelConsumed = distance / FuelEfficiency;
        if (CurrentFuelLevel >= fuelConsumed)
        {
            CurrentFuelLevel -= fuelConsumed;
            Console.WriteLine($"Traveled {distance} km. Fuel consumed: {fuelConsumed} liters. Remaining fuel: {CurrentFuelLevel} liters.");
        }
        else
        {
            Console.WriteLine("Not enough fuel for Please refuel.");
        }
    }

}


