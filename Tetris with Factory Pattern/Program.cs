using System;

namespace Tetris_with_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {           
            string[] menu = Configuration.GetFiguresMenu();
            byte menuLength = Convert.ToByte(menu.Length);

            while (true)
            {
                for (byte i = 0; i < menuLength; i++)
                {
                    Console.WriteLine($"{i + 1}) {menu[i]}");
                }
                Console.Write("\nWhich figure do you want, enter choice number: ");

                bool isNumber = byte.TryParse(Console.ReadLine(), out byte choiceNumber);

                while (isNumber == false || Verify.IsChoiceExist(choiceNumber, menuLength) == false)
                {
                    Console.Write("\nEnter correct choice number please: ");
                    isNumber = byte.TryParse(Console.ReadLine(), out choiceNumber);
                }

                IFigure figure = TetrisFactory.GetFigureWithChoiceNumber(choiceNumber);

                Console.Clear();
                figure.PrintAllData();

                Console.Write("Press any key to continue...");
                Console.ReadLine();                
                Console.Clear();
            }
        }
    }
}