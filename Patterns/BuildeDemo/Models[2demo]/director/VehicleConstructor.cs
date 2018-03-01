namespace Builder.Directors
{
    using Builder.Builders;

    /// <summary>
    /// The 'Director' class
    /// Constructs an object using the Builder interface
    /// </summary>
    public class VehicleConstructor
    {
        // There may be different constructors (with different steps order)
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}