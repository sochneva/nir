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
        public double Pnv;
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
        /*
        public double calcN(inParam inParam)
        {
            return outParam.N * Interpolation(t) * Interpolation(Ngtu) * Interpolation(Tnv) * Interpolation(Pnv) * Interpolation(dPin) * Interpolation(dPout);
        }

        public double calcNu(inParam inParam)
        {
            return outParam.Nu * Interpolation(t) * Interpolation(Ngtu) * Interpolation(Tnv) * Interpolation(dPin) * Interpolation(dPout);
        }

        public double calcG(inParam inParam)
        {
            return outParam.G * Interpolation(Ngtu) * Interpolation(Tnv) * Interpolation(Pnv) * Interpolation(dPin) * Interpolation(dPout);
        }

        public double calcT(inParam inParam)
        {
            return outParam.T * Interpolation(Ngtu) * Interpolation(Tnv) * Interpolation(dPin) * Interpolation(dPout);
        }

        public double calcB(outParam outParam)
        {
            return outParam.N / (outParam.Q * outParam.Nu);
        }
        */
        public double Interpolation(double x, double[,] arr)
        {
            int i = 0;
            while (x > arr[0, i]) i++;
            return (arr[1, i] - arr[1, i - 1]) / (arr[0, i] - arr[0, i - 1]) * (x - arr[0, i - 1]) + arr[1, i - 1];
        }

    }
}
