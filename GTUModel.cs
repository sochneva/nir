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
        private Dictionary<string, string> FilenameData = new Dictionary<string, string>(); //пути к файлам с данными для расчета 
        private Dictionary<string, double[,]> Data { get; set; } = new Dictionary<string, double[,]>();   //данные для расчета

        #region inputParam
        private static double OperatingTime { get; set; }                //Колич. часов экспл., ч
        private double StrainGTU { get; set; }                           //Нагрузка ГТУ, %
        private double OutdoorAirTemperature { get; set; }               //Темп. нар. воздуха, °C
        private double OutdoorAirPressure { get; set; }                  //Давление нар. воздуха, кПа
        private double PressureLossIn { get; set; }                      //Потери давлен на входе в компр., кПа
        private double PressureLossOut { get; set; }                     //Потери давлен на вых. ГТ, кПа
        #endregion

        #region outputParam
        public double N { get { return calcN(); } }                     //Электрическая мощность ГТУ брутто
        public double Nu { get { return calcNu(); } }                   //Электрический КПД брутто
        public double G { get { return calcG(); } }                     //Расход выхлопных газов
        public double T { get { return calcT(); } }                     //Температура выхлопных газов
        public double B                                                 //Расход природного газа
        {
            get
            {
                return N / (Q * Nu);
            }
        }            
        public double Q { get; set; }                                   //Низшая теплота сгорания топлива
        #endregion

        #region controlParam
        private double DefN { get; } = 155.3;      //Электрическая мощность ГТУ брутто
        private double DefNu { get; } = 98.54;     //Электрический КПД брутто
        private double DefG { get; } = 509.0;      //Расход выхлопных газов
        private double DefT { get; } = 537.0;      //Температура выхлопных газов
        private double DefB                        //Расход природного газа
        {
            get
            {
                return DefN / (DefQ * DefNu);
            }
        }
        public double DefQ { get; } = 29;          //Низшая теплота сгорания топлива
        #endregion


        public GTUModel()
        {
            string filenameBase = AppDomain.CurrentDomain.BaseDirectory;

            FilenameData.Add("G(dPin)", filenameBase + @"DataFiles\G(dPin).txt");
            FilenameData.Add("G(Ngtu)", filenameBase + @"DataFiles\G(Ngtu).txt");
            FilenameData.Add("dPinTrackBar", filenameBase + @"DataFiles\N(dPin).txt");
            FilenameData.Add("TnvTrackBar", filenameBase + @"DataFiles\N(Tnv).txt");
            FilenameData.Add("PnvTrackBar", filenameBase + @"DataFiles\N,G(Pnv).txt");
            FilenameData.Add("dPoutTrackBar", filenameBase + @"DataFiles\N,Nu(dPout).txt");
            FilenameData.Add("Nu(dPin)", filenameBase + @"DataFiles\Nu(dPin).txt");
            FilenameData.Add("NgtuTrackBar", filenameBase + @"DataFiles\Nu(Ngtu).txt");
            FilenameData.Add("Nu(Tnv)", filenameBase + @"DataFiles\Nu(Tnv).txt");
            FilenameData.Add("T(dPin)", filenameBase + @"DataFiles\T(dPin).txt");
            FilenameData.Add("T(dPout)", filenameBase + @"DataFiles\T(dPout).txt");
            FilenameData.Add("T(Ngtu)", filenameBase + @"DataFiles\T(Ngtu).txt");
            FilenameData.Add("T(Tnv)", filenameBase + @"DataFiles\T(Tnv).txt");
            FilenameData.Add("tTrackBar", filenameBase + @"DataFiles\t.txt");

            foreach (var x in FilenameData)
                Data.Add(x.Key, FileManager.ReadFromFile(x.Value));
        }

        public void updateParam(string name, int value)
        {
            double newValue = Data[name][0, 0] + value * (Data[name][0, Data[name].GetLength(1) - 1] - Data[name][0, 0]) / 100;
            switch (name)
            {
                case "tTrackBar":
                    OperatingTime = newValue;
                    break;
                case "TnvTrackBar":
                    OutdoorAirTemperature = newValue;
                    break;
                case "PnvTrackBar":
                    OutdoorAirPressure = newValue;
                    break;
                case "NgtuTrackBar":
                    StrainGTU = newValue;
                    break;
                case "dPinTrackBar":
                    PressureLossIn = newValue;
                    break;
                case "dPoutTrackBar":
                    PressureLossOut = newValue;
                    break;
            }
            
        }

        private double calcN()
        {
            return DefN * Interpolation(OperatingTime, Data["tTrackBar"]) * Interpolation(StrainGTU, Data["NgtuTrackBar"])
                * Interpolation(OutdoorAirTemperature, Data["TnvTrackBar"]) * Interpolation(OutdoorAirPressure, Data["PnvTrackBar"])
                * Interpolation(PressureLossIn, Data["dPinTrackBar"]) * Interpolation(PressureLossOut, Data["dPoutTrackBar"]);
        }

        private double calcNu()
        {
            return DefNu * Interpolation(OperatingTime, Data["tTrackBar"]) * Interpolation(StrainGTU, Data["NgtuTrackBar"])
                * Interpolation(OutdoorAirTemperature, Data["TnvTrackBar"]) * Interpolation(PressureLossIn, Data["dPinTrackBar"])
                * Interpolation(PressureLossOut, Data["dPoutTrackBar"]);
        }

        private double calcG()
        {
            return DefG * Interpolation(StrainGTU, Data["tTrackBar"]) * Interpolation(OutdoorAirTemperature, Data["PnvTrackBar"])
                * Interpolation(OutdoorAirPressure, Data["TnvTrackBar"]) * Interpolation(PressureLossIn, Data["dPinTrackBar"])
                * Interpolation(PressureLossOut, Data["dPoutTrackBar"]);
        }

        private double calcT()
        {
            return DefT * Interpolation(StrainGTU, Data["NgtuTrackBar"]) * Interpolation(OutdoorAirTemperature, Data["PnvTrackBar"])
                * Interpolation(OutdoorAirPressure, Data["TnvTrackBar"]) * Interpolation(PressureLossIn, Data["dPinTrackBar"]) * Interpolation(PressureLossOut, Data["dPoutTrackBar"]);
        }

        private double Interpolation(double x, double[,] arr)
        {
            int i = 0;
            while (x > arr[0, i] && i<arr.GetLength(1)-2) i++;
            return (arr[1, i+1] - arr[1, i]) / (arr[0, i+1] - arr[0, i]) * (x - arr[0, i+1]) + arr[1, i];
        }
    }
}
