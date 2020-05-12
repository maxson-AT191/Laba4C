using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Laba_WindowsForm_ComplexNumber
{
    class ComplexNumber
    {
        private double modulP;
        private double argumentNum;
        private double realPart;        //Действительная часть(свободный коэфициент)
        private double imaginaryPart;   //Мнимая часть(при мнимой единице)

        public ComplexNumber(double a, double b)
        {
            realPart = a;
            imaginaryPart = b;
            ModulP = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            ArgumentNum = ArgumentNumMethod(a, b);
        }

        public double ModulP { get => modulP; private set => modulP = value; }
        public double ArgumentNum { get => argumentNum; private set => argumentNum = value; }
        public double RealPart { get => realPart; set => realPart = value; }
        public double ImaginaryPart { get => imaginaryPart; private set => imaginaryPart = value; }

        private double ArgumentNumMethod(double a, double b)
        {
            if (a > 0)
            {
                return Math.Atan(b / a);
            }
            else if (a < 0 && b > 0)
            {
                return Math.PI + Math.Atan(b / a);
            }
            else return -Math.PI + Math.Atan(b / a);
        }

        public static ComplexNumber Pow(ComplexNumber first, double n)
        {
            return new ComplexNumber(Math.Round(Math.Cos(first.ArgumentNum * n) * Math.Pow(first.ModulP, n), 2), Math.Round(Math.Sin(first.ArgumentNum * n) * Math.Pow(first.ModulP, n), 2));
        }

        public override string ToString()
        {
            return string.Format($"Комплексное число - {realPart}+{imaginaryPart}*i" +
                $"\nМодуль комплексного числа = {Math.Round(ModulP, 2)}" +
                $"\nАргумент комплекного числа = {Math.Round(ArgumentNum * 57, 2)}" +
                $"\nТригонометрическая форма - {Math.Round(ModulP, 2)}*(cos({Math.Round(ArgumentNum * 57, 2)})+i*sin({Math.Round(ArgumentNum * 57, 2)})))" +
                $"\nПоказательная форма - {Math.Round(ModulP, 2)}*e^(i*{Math.Round(ArgumentNum * 57, 2)})");
        }

        public string BineryString()
        {
            return string.Format($"{realPart} {imaginaryPart}");
        }

        public virtual bool Save(string fName)
        {
            try
            {
                FileStream file = new FileStream(fName, FileMode.OpenOrCreate, FileAccess.Write);
                // Создаем двоичный поток для записи
                BinaryWriter bw = new BinaryWriter(file, Encoding.UTF8);
                bw.Write(BineryString());
                bw.Close();
                file.Close();
            }
            catch (IOException exception)
            {
                //MessageBox.Show(exception.Message);
                return false;
            }

            return true;
        }

        public virtual ComplexNumber Load(string fName)
        {
            try
            {
                FileStream file = new FileStream(fName, FileMode.Open, FileAccess.Read);
                // Создаем двоичный поток для записи
                BinaryReader binery = new BinaryReader(file, Encoding.UTF8);
                string result = binery.ReadString();
                binery.Close();
                file.Close();
                char temp = ' ';
                int index = result.IndexOf(temp);
                string real = result.Substring(0, index);
                string imagine = result.Substring(index);
                return new ComplexNumber(Double.Parse(real), Double.Parse(imagine));
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
                //System.Windows.Forms.MessageBox.Show(exception.Message);
                return new ComplexNumber(0, 0);
            }


        }

        public static ComplexNumber operator +(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.realPart + second.realPart, first.imaginaryPart + second.imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(first.realPart - second.realPart, first.imaginaryPart - second.imaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber first, ComplexNumber second)
        {
            return new ComplexNumber(Math.Round(first.realPart * second.realPart - first.imaginaryPart * second.imaginaryPart, 2), Math.Round(first.realPart * second.imaginaryPart + first.imaginaryPart * second.realPart, 2));
        }

        public static ComplexNumber operator /(ComplexNumber first, ComplexNumber second)                                   //Первое компл.число умножаю на второе компл.число,
        {                                                                                                                   //при этом мнимая часть становится отрицательной;
            return first * new ComplexNumber(Math.Round(second.realPart * (1d / second.ModulP), 2), Math.Round(-second.imaginaryPart * (1d / second.ModulP), 2)); //дальше делю на модуль второго комплексного числа
        }
    }
}
