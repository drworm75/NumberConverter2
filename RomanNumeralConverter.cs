using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    public class RomanNumeralConverter
    {
        public string Convert(int numberToConvert)
        {
            string RomanNumeral = "";
            int lastNumber = numberToConvert % 10;

            while (numberToConvert > 1000)
            {
                RomanNumeral += "M";
                numberToConvert -= 1000;

                if (numberToConvert < 1000 && numberToConvert >= 900)
                {
                    RomanNumeral += "CM";
                    numberToConvert -= 900;

                }
            }

            while (numberToConvert > 50)
            {
                RomanNumeral += "L";
                numberToConvert -= 50;
            }

            while (numberToConvert > 10)
            {

                if (numberToConvert < 10 && lastNumber == 9)
                {
                    RomanNumeral += "IX";
                    numberToConvert -= 9;
                }

                else
                {
                    RomanNumeral += "X";
                    numberToConvert -= 10;
                }
            }

            while (numberToConvert > 5)
            {
                if (lastNumber == 9)
                {
                    RomanNumeral += "IX";
                    numberToConvert -= 9;
                }

                else 
                RomanNumeral += "V";
                numberToConvert -= 5;
            }

            if (numberToConvert > 0 && lastNumber == 9)
            {
                RomanNumeral += "IX";
            }

            if (numberToConvert > 0 && lastNumber == 4)
            {
                RomanNumeral += "IV";
            }

            /*
            if (numberToConvert > 10)
            {
                numberToConvert -= 10;
                return "X";

            }
            */

            switch (numberToConvert)
            {
                case (1):
                    RomanNumeral += "I";
                    break;
                case (3):
                    RomanNumeral += "III";
                    break;
            }

            return RomanNumeral;
        }

    }
}
