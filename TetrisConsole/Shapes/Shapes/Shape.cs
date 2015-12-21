using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public abstract class Shape
    {
        //protected const int ShapeDimensionSize = 4;

        private int xCord;
        private int yCord;
        private char[,] shapeDisplay;
        private string shapeName;
        private ShapeState currentShapeState;

        public int XCord
        {
            get { return this.xCord; }
            set { this.xCord = value; }
        }

        public int YCord
        {
            get { return this.yCord; }
            set { this.yCord = value; }
        }

        public char[,] ShapeDisplay
        {
            get { return this.shapeDisplay; }
            set { this.shapeDisplay = value; }
        }

        public string ShapeName
        {
            get { return this.shapeName; }
            set { this.shapeName = value; }
        }

        public ShapeState CurrentShapeState
        {
            get { return this.currentShapeState; }
            set { this.currentShapeState = value; }
        }

    }
}
