using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    class SortingHat
    {
        String identity = "";
        public SortingHat(String identity)
        {
            this.identity = identity;
        }

        enum Colleges
        {
            Gryffindor,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }

        public void WhatCollege()
        {
            if (identity == "intelligent")
            {
                Console.WriteLine("You are going to be a part of " + Colleges.Ravenclaw);
            }
            else if (identity == "brave")
            {
                Console.WriteLine("You are going to be a part of " + Colleges.Gryffindor);
            }
            else if (identity == "loyal")
            {
                Console.WriteLine("You are going to be a part of " + Colleges.Hufflepuff);
            }
            else
                Console.WriteLine("You are going to be part of" + Colleges.Slytherin);
        }
    }
}
