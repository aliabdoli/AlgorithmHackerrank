﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHackerrank.Searching;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace AlgorithmHackerrank.Tests.Searching
{
    [TestFixture]
    public class PairsAlgorithmTests
    {
        [Test]
        [TestCase(@"5 2  
1 5 3 4 2")]
        public void MainFlow(string inputString)
        {
            var algor = new PairsAlgorithm();
            var input = new StringReader(inputString);
            string[] nk = input.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(input.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int result = algor.pairs(k, arr);

        }
    }
}
