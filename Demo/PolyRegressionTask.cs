﻿using MLNet;
using MLNet.Losses;
using MLNet.Metrics;
using MLNet.Models.Regression;
using MLNet.Optimizers;
using Numpy;

namespace Demo
{
    public class PolyRegressionTask
    {
        public static void Run()
        {
            var x = Enumerable.Range(0, 200).Select(a => a * 0.01 - 2).ToArray();
            var X = np.expand_dims(np.array(x), -1);
            var Y = -2 + 1.5 * X - 3 * np.square(X);


            var pr = new PolyRegression(2);
            var trainPlan = new TrainPlan(1000, learningRate: 5E-2);

            pr.GiveOptimizer(new Momentum(trainPlan.LearningRate));
            pr.GiveLoss(new LSLoss {Constraint = Constraint.None});
            pr.GiveMetric(new MSE(), new MAE());
            pr.Fit(X, Y, trainPlan);
        }
    }
}