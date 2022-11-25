using System;
using System.Collections.Generic;

namespace GetResistance
{
    class Program
    {
        public static string ReturnOhms(string color1, string color2, string color3)
        {
            Dictionary<string, int> colorValues = new Dictionary<string, int>()
            {
                {"Black", 0},
                {"Brown", 1},
                {"Red", 2},
                {"Orange", 3},
                {"Yellow", 4},
                {"Green", 5},
                {"Blue", 6},
                {"Violet", 7},
                {"Grey", 8},
                {"White", 9}
            };

            int integerValueOfColor1 = colorValues.ContainsKey(color1) ? colorValues[color1] : -1;
            int integerValueOfColor2 = colorValues.ContainsKey(color2) ? colorValues[color2] : -1;
            int integerValueOfColor3 = colorValues.ContainsKey(color3) ? colorValues[color3] : -1;

            if (integerValueOfColor1 == -1 || integerValueOfColor2 == -1 || integerValueOfColor3 == -1)
            {
                return "Invalid color input";
            }

            string output = integerValueOfColor1.ToString() + integerValueOfColor2.ToString();
            string outputForThirdColor = "";

            if (Int32.Parse(output) == 0)
            {
                outputForThirdColor = " ";
            }
            else
            {
                if (integerValueOfColor3 < 3)
                {
                    for (int zeroes = 0; zeroes < integerValueOfColor3; zeroes++)
                    {
                        outputForThirdColor += "0";
                    }
                    outputForThirdColor += " ";
                }
                else
                {
                    for (int zeroes = 0; zeroes < integerValueOfColor3 - 3; zeroes++)
                    {
                        outputForThirdColor += "0";
                    }
                    outputForThirdColor += " kilo";
                }
            }
            output = Int32.Parse(output).ToString();
            output += outputForThirdColor + "ohms";

            return output;
        }
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input != null && input != "")
            {
                string[] colors = input.Split("-");
                if (colors.Length != 3)
                {
                    Console.WriteLine("Invalid color input");
                    return;
                }
                string output = ReturnOhms(colors[0], colors[1], colors[2]);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
