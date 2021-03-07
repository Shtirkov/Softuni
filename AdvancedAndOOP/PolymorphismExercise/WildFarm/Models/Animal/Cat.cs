﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string breed)
            : base(name, weight, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
