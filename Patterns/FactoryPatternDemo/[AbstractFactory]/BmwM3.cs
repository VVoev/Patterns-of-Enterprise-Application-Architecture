namespace FactoryPatternDemo._AbstractFactory_
{
    public class BmwM3 : Car, IAutomobile
    {
        public double EngineSize
        {
            get
            {
                return 4.4;
            }
        }

        public int HorsePower
        {
            get
            {
                return 455;
            }
        }

        public void IntroDuce()
        {
            base.IntroDuce(HorsePower, EngineSize);
        }
    }

}
