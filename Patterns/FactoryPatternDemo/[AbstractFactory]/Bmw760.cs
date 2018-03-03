namespace FactoryPatternDemo._AbstractFactory_
{
    public class Bmw760 : Car, IAutomobile
    {
        public double EngineSize
        {
            get
            {
                return 6.0;
            }
        }

        public int HorsePower
        {
            get
            {
                return 555;
            }
        }

        public void IntroDuce()
        {
            base.IntroDuce(HorsePower, EngineSize);
        }
    }

}
