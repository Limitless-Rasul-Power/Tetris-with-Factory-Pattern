using System;
using System.Collections;

namespace Tetris_with_Factory_Pattern
{
    public class ZTetracube : IFigure
    {
        public ZTetracube()
        {
            Red = 255;
            Green = 0;
            Blue = 0;
            FormName = "Z Tetracube";
            FillForm();
        }

        public BitArray Form { get; set; } = new BitArray(length: 16);
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public string FormName { get; set; }

        public void FillForm()
        {
            Form[0] = true;
            Form[1] = true;
            Form[5] = true;
            Form[6] = true;
        }

        public void PrintAllData()
        {
            Console.WriteLine($"Form Name: {FormName}");
            Console.WriteLine($"RGB: ({Red}, {Green}, {Blue})");
            Console.WriteLine("\nFigure Form Visualization");

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < 16; i++)
            {
                if (Form[i])
                {
                    Console.Write("■");
                }
                else
                {
                    Console.Write(" ");
                }


                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ResetColor();
        }
    }
}