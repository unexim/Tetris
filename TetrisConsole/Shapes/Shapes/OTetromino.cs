using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class OTetromino : Shape
    {


        public OTetromino(int x, int y, char[,] shape, ShapeState state)
        {
            // TODO : Implement logic here
        }

        private char[,] OTetrominoALLState()
        {
            char[,] arr = new char[,]  {  {' ',' ',' ',' ',},
                                          {' ','#','#',' ',},
                                          {' ','#','#',' ',},
                                          {' ',' ',' ',' ',}};

            return arr;
        }

    }
}
