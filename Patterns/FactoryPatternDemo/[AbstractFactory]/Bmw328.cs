namespace FactoryPatternDemo._AbstractFactory_
{
    public class Bmw328 : Car, IAutomobile
    {
        public double EngineSize
        {
            get
            {
                return 2.8;
            }
        }

        public int HorsePower
        {
            get
            {
                return 245;
            }
        }

        public void IntroDuce()
        {
            base.IntroDuce(HorsePower, EngineSize);
        }
    }

}
