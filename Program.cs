﻿using System;

namespace Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingHat person = new SortingHat("intelligent");
            SortingHat person2 = new SortingHat("brave");
            SortingHat person3 = new SortingHat("loyal");
            person.WhatCollege(person);
            person.WhatCollege(person2);
            person.WhatCollege(person3);
        }
    }
}
