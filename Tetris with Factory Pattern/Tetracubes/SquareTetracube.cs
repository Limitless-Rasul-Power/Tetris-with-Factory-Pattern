using System;
using System.Collections;

namespace Tetris_with_Factory_Pattern
{
    public class SquareTetracube : IFigure
    {
        public SquareTetracube()
        {
            Red = 0;
            Green = 255;
            Blue = 255;
            FormName = "Square Tetracube";
            FillForm();
        }

        public BitArray Form { get; set; } = new BitArray(length: 16);
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public string FormName { get; set; }


        public void FillForm()
        {
            Form[5] = true;
            Form[6] = true;
            Form[9] = true;
            Form[10] = true;
        }
        public void PrintAllData()
        {
            Console.WriteLine($"Form Name: {FormName}");
            Console.WriteLine($"RGB: ({Red}, {Green}, {Blue})");
            Console.WriteLine("\nFigure Form Visualization");

            Console.ForegroundColor = ConsoleColor.Cyan;

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