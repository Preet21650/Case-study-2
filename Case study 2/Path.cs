﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy2
{
    public class Path
    {
            public List<City> Cities = new List<City>();

            public double Distance;

            public Path()
            {
                Distance = 0;
                //loop thru all the Cities, use X Y coordinate to work out distance (Pythagoras), add them together to get total distance 
            }
            public void calDistance()
            {

                for (int i = 1; i < Cities.Count; i++)
                {
                    Distance = (Distance + Math.Sqrt(Math.Pow((Cities[i].X - Cities[i - 1].X), 2) + Math.Pow((Cities[i].Y - Cities[i - 1].Y), 2)));
                }
            }

    }

    
}