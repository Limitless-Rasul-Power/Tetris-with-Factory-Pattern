using System;
using System.Collections;

namespace Tetris_with_Factory_Pattern
{
    public class LTetracube : IFigure
    {
        public LTetracube()
        {
            Red = 255;
            Green = 0;
            Blue = 255;
            FormName = "L Tetracube";
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
            Form[2] = true;
            Form[3] = true;
            Form[4] = true;   
        }

        public void PrintAllData()
        {
            Console.WriteLine($"Form Name: {FormName}");
            Console.WriteLine($"RGB: ({Red}, {Green}, {Blue})");
            Console.WriteLine("\nFigure Form Visualization");

            Console.ForegroundColor = ConsoleColor.Magenta;

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