using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class ITetromino : Shape
    {


        public ITetromino(int x, int y, char[,] shape, ShapeState state)
        {
            // TODO : Implement logic here
        }


        private char[,] ITetreminoUPState()
        {
            char[,] arr = new char[,]  {  {' ',' ','#',' ',},
                                          {' ',' ','#',' ',},
                                          {' ',' ','#',' ',},
                                          {' ',' ',' ',' ',}};

            return arr;

        }

        private char[,] ITetreminoRIGHTState()
        {
            char[,] arr = new char[,]  {  {' ',' ',' ',' ',},
                                          {' ','#','#','#',},
                                          {' ',' ',' ',' ',},
                                          {' ',' ',' ',' ',}};

            return arr;

        }

        private char[,] ITetreminoDOWNState()
        {
           
            return ITetreminoUPState();

        }

        private char[,] ITetreminoLEFTState()
        {

            return ITetreminoRIGHTState();

        }
    }
}
