namespace Tetris_with_Factory_Pattern
{
    public static class TetrisFactory
    {
        public static IFigure GetFigureWithChoiceNumber(byte choiceNumber)
        {
            switch (choiceNumber)
            {
                case TetrisFigureNumbers.StraightTetracube:
                    {
                        return new StraightTetracube();
                    }

                case TetrisFigureNumbers.SqaureTetracube:
                    {
                        return new SquareTetracube();
                    }

                case TetrisFigureNumbers.TTetracube:
                    {
                        return new TTetracube();
                    }

                case TetrisFigureNumbers.LTetracube:
                    {
                        return new LTetracube();
                    }

                case TetrisFigureNumbers.JTetracube:
                    {
                        return new JTetracube();
                    }

                case TetrisFigureNumbers.SkewTetracube:
                    {
                        return new SkewTetracube();
                    }

                case TetrisFigureNumbers.ZTetracube:
                    {
                        return new ZTetracube();
                    }

            }

            return null;
        }
    }
}