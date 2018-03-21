using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Startup
    {
        static void Main(string[] args)
        {
            var flight1 = new Airbus321();
            var boing2 = new Boing2();
            var stealth3 = new Stealth3();
        }

     
    }

    public abstract class Aicraft
    {
        private int currentAttitude;
        private readonly IAirTraficControl airTraficControl;
        protected IList<Aicraft> acknowledgedAicraft = new List<Aicraft>();

        protected Aicraft(string callSign,IAirTraficControl airTraficControl)
        {
            this.CallSign = callSign;
            this.airTraficControl = airTraficControl;
        }

        public void Acknowledge(Aicraft aicraft)
        {
            acknowledgedAicraft.Add(aicraft);
        }

        public abstract int Ceiling { get; }

        public abstract bool isTrailingGapAcceptable();

        public string CallSign { get; }

        public int Atitude
        {
            get
            {
                return this.currentAttitude;
            }
        }
    }

    public class Airbus321 : Aicraft
    {
        public Airbus321(string callsign) : base(callsign)
        {
        }

        public override int Ceiling => 41000;

        public override bool isTrailingGapAcceptable()
        {
            foreach (var acknowledgedAicraft in this.acknowledgedAicraft)
            {
                if(acknowledgedAicraft.GetType() == typeof(Boing2))
                {

                }

                if (acknowledgedAicraft.GetType() == typeof(Stealth3))
                {

                }
            }

            return false;
        }
    }

    public class Boing2
    {
        public Boing2()
        {
        }
    }
    public class Stealth3
    {
        public Stealth3()
        {
        }
    }

    public interface IAirTraficControl
    {
        void ReceiveAircraftLocation(Aicraft location);
        void RegisterAircraftUnderGuidance(Aicraft aicraft);
    }
}
