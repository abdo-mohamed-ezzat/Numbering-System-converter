using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace numbreing
{
    public  class Decimal
    {

        public  string decToOctal(double decimalNum)
        {
            double decimalhexa = decimalNum;
            int octalNum = 0;
            int i = 1;
            while (decimalNum != 0)
            {

                octalNum += (int)(decimalNum % 8) * i;
                decimalNum /= 8;
                i *= 10;

            }
            return octalNum.ToString();
        }
        public  string decToHexa(int decimalNum)
        {

            List<char> hexaNum = new List<char>();

            int i = 0;
            while (decimalNum != 0)
            {
                int temp = 0;
                temp = decimalNum % 16;
                if (temp < 10)
                {
                    hexaNum.Add((char)(temp + 48));
                    i++;
                }
                else
                {
                    hexaNum.Add((char)(temp + 55));
                    i++;
                }

                decimalNum = decimalNum / 16;
            }
            string num = "";
            for (i = hexaNum.Count - 1; i >= 0; i--)
                num += hexaNum[i];
            return num;
        }
        public  string decToBinary(int decimalNum)
        {
            List<int> binaryNum = new List<int>();
            int i = 0;
            while (decimalNum > 0)
            {

                binaryNum.Add(decimalNum % 2);
                decimalNum = decimalNum / 2;
                i++;
            }
            string num = "";
            for (int j = binaryNum.Count - 1; j >= 0; j--)
                num += binaryNum[j];
            return num;
        }
        public string Todecimal(int @base, string input_)
        {
            int power = 0;
            double number = 0;
          
            for (int index = input_.Length - 1; index >= 0; index--)
            {
                int charchter = 0;

                try
                {
                    charchter = int.Parse(input_[index].ToString());
                }
                catch
                {
                    switch (input_[index].ToString())
                    {
                        case "A":
                            charchter = 10;
                            break;
                        case "B":
                            charchter = 11;
                            break;
                        case "C":
                            charchter = 12;
                            break;
                        case "D":
                            charchter = 13;
                            break;
                        case "F":
                            charchter = 14;
                            break;
                        case "E":
                            charchter = 15;
                            break;
                    }
                }


                number += charchter * Math.Pow(@base, power);
                power++;

            }
            return number.ToString();
        }
    }
}


