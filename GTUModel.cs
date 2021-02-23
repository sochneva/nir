using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nir
{
    class GTUModel
    {
        public double OperatingTime { get; set; }
        public double StrainGTU { get; set; }
        public double OutdoorAirTemperature { get; set; }
        public double OutdoorAirPressure { get; set; }
        public double PressureLossIn { get; set; }
        public double PressureLossOut { get; set; }

        public void updateParam(string name, int value)
        {
            switch (name)
            {
                case "trackBar1":
                    OperatingTime = value;
                    break;
                case "trackBar2":
                    OutdoorAirTemperature = value;
                    break;
                case "trackBar3":
                    OutdoorAirPressure = value;
                    break;
                case "trackBar4":
                    StrainGTU = value;
                    break;
                case "trackBar5":
                    PressureLossIn = value;
                    break;
                case "trackBar6":
                    PressureLossOut = value;
                    break;
            }
        }

        public static double Nformula()
        {
            return 0;
        }
        public static double nformula()
        {
            return 0;
        }
        public static double Gformula()
        {
            return 0;
        }
        public static double Tformula()
        {
            return 0;
        }
    }
}
