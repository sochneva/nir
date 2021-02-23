using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nir
{
    public struct inParam
    {
        public double t;
        public double Ngtu;
        public double Tnv;
        public double dPin;
        public double dPout;
    }

    public struct outParam
    {
        public double N; //= 155.3;   //Электрическая мощность ГТУ брутто
        public double Nu; //= 98.54;  //Электрический КПД брутто
        public double G; //= 509.0;   //Расход выхлопных газов
        public double T; //= 537.0;   //Температура выхлопных газов
        public double B;   //Расход природного газа
        public double Q;   //Низшая теплота сгорания топлива
    }

    public class GTU
    {
        private outParam outParam;

        public double calcN(inParam inParam)
        {

            return outParam.N;
        }
        public double Interpolation(double x, double x1, double x2, double y1, double y2)
        {
            double[][] arr;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                if (x > arr[0][i]) continue;
                x1 = arr[0][i - 1];
                x2 = arr[0][i];
                y1 = arr[1][i - 1];
                y2 = arr[1][i];
                break;
            }

            return (y2 - y1) / (x2 - x1) * (x - x1) + y1;
        }

    }
}
