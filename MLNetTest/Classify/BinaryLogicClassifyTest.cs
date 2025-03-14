﻿using MLNet.Utils;
using Numpy;
using Xunit.Abstractions;

namespace MLNetTest.Classify
{
    public class BinaryLogicClassifyTest : AbstractUnitTest
    {
        private readonly string singledata = @"..\..\..\..\DataSet\data_multivar.txt";

        public BinaryLogicClassifyTest(ITestOutputHelper testOutputHelper)
            : base(testOutputHelper)
        {
            var data = np2.load(singledata);
            X = data[":,1:2"];
            Y = data[":,2:3"];
        }

        protected NDarray X { set; get; }
        protected NDarray Y { set; get; }


        //[Fact]
        //public void BinaryLogicClassify()
        //{
        //    var lr = new BinaryLogicClassify
        //    {
        //        Print = true,
        //        Kernel = new Poly(1)
        //    };
        //    lr.Fit(X, Y, new TrainPlan());
        //    lr.PrintSelf();

        //    var y = lr.Call(X);
        //    print(y);
        //}
    }
}