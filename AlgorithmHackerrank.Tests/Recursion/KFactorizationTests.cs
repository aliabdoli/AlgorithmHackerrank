﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmHackerrank.Recursion;
using NUnit.Framework;

namespace AlgorithmHackerrank.Tests.Recursion
{
    [TestFixture]
    public class KFactorizationTests
    {
        [Test]
//        [TestCase(@"12 3
//2 3 4")]
        //        [TestCase(@"72 9
        //2 4 6 9 3 7 16 10 5")]
//        [TestCase(@"15 5
//2 10 6 9 11")]
        [TestCase(@"231000000 8
2 3 5 7 11 13 17 19", "1 2 4 8 16 32 64 192 960 4800 24000 120000 600000 3000000 21000000 231000000")]


        public void MainFlow(string inputString, string output)
        {
            var input = new StringReader(inputString);

            string[] nk = input.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] A = Array.ConvertAll(input.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp))
                ;
            int[] result = kFactorization.Do(n, A);

            var finalresult = string.Join(" ", result);
            Assert.AreEqual(output, finalresult);

        }
    }
}
