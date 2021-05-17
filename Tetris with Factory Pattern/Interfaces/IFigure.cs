using System.Collections;

namespace Tetris_with_Factory_Pattern
{
    public interface IFigure
    {        
        BitArray Form { get; set; }
        byte Red { get; set; }
        byte Green { get; set; }
        byte Blue { get; set; }
        string FormName { get; set; }
        void FillForm();
        void PrintAllData();
    }
}