﻿using System;

namespace TestProject
{
    public class MathLibrary
    {
        private int _value = 0;

        public int Value => _value;

        public MathLibrary(int defaultValue)
        {
            
        }

        public MathLibrary Add(int value)
        {
            //_value += value;
            return this;
        }
    }
}
