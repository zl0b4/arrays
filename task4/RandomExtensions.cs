﻿using System;

namespace DoubleMinMax
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random RandGenerator, double MinValue, double MaxValue)
        {
            return RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue;
        }
    }
}