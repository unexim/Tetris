using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class STetromino : Shape
    {
        

        public STetromino(int x, int y, char[,] shape, ShapeState state)
        {
            // TODO : Implement logic here
        }

        private char[,] STetreminoUPState()
        {
            char[,] arr = new char[,]  {  {' ',' ','#',' ',},
                                          {' ','#','#',' ',},
                                          {' ','#',' ',' ',},
                                          {' ',' ',' ',' ',}};

            return arr;
                                                                    
        }

        private char[,] STetreminoRIGHTState()
        {
            char[,] arr = new char[,]  {  {' ',' ',' ',' ',},
                                          {' ','#','#',' ',},
                                          {' ',' ','#','#',},
                                          {' ',' ',' ',' ',}};

            return arr;

        }

        private char[,] STetreminoDOWNState()
        {


            return STetreminoUPState();

        }

        private char[,] STetreminoLEFTState()
        {


            return STetreminoRIGHTState();

        }

    }
}
