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

        public void WhatCollege(SortingHat person)
        {
            if (person.identity == "intelligent")
            {
                Console.WriteLine("You are going to be a part of " + Colleges.Ravenclaw);
            }
            else if (person.identity == "brave")
            {
                Console.WriteLine("You are going to be a part of " + Colleges.Gryffindor);
            }
            else if (person.identity == "loyal")
            {
                Console.WriteLine("You are going to be a part of " + Colleges.Hufflepuff);
            }
            else
                Console.WriteLine("You are going to be part of" + Colleges.Slytherin);
        }
    }
}
