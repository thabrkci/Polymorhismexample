// The Schoolroad class inherits from Stabilizethecarspeed class, representing the road to school.
// It overrides the stabilizeCar method to provide instructions specific to school roads.
public class SchoolRoad : Stabilizethecarspeed
{
    public override void stabilizeCar()
    {
        // Calls the base class method to give a general speed stabilization warning to the driver.
        base.stabilizeCar();
        
        // Outputs a message to inform the driver that they are on the way to school.
        Console.WriteLine("Your location is on the way to school.");
        
        // Calls the base class method to provide a warning for the driver to slow down.
        base.stabilizeCarslow();
        
        // Outputs a message instructing the driver to check left and right for safety.
        Console.WriteLine("Check left and right.");
    }
}
