﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talia_Zwyciestwa.Classes
{
    abstract public class Card
    {
        private int value;
        private string name;
        private string describtion;

        public int Value { get => value; set => this.value = value; }
        public string Name { get => name; set => name = value; }
        public string Describtion { get => describtion; set => describtion = value; }

        abstract public void Effect(Player player, Enemy enemy);
    }

}
