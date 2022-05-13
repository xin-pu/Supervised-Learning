﻿using MLNet.Transforms;

namespace MLNet.Models.Regression
{
    public class TrianglePolyRegression : PolyRegression
    {
        /// <summary>
        ///     TrianglePolyRegression
        ///     y= α +β1*sin(x/2)+β2*cos(x/2)+...+βn*cos(degree*x/2)]
        /// </summary>
        /// <param name="degree"></param>
        public TrianglePolyRegression(
            int degree = 1)
        {
            Degree = degree;
            Transform = new TrianglePoly(Degree);
        }
    }
}