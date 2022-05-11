﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine : Figure
    {
        public VertikalLine(int yUp, int uDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= uDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
