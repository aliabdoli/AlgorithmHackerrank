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
    public class MissingNumbersTests
    {
        [Test]
        [TestCase(@"10
203 204 205 206 207 208 203 204 205 206
13
203 204 204 205 206 207 205 208 203 206 205 206 204")]
        public void MainFlow(string inputString)
        {
            var inputStream = new StringReader(inputString);
            var algor = new MissingNumbers();

            int n = Convert.ToInt32(inputStream.ReadLine());

            int[] arr = Array.ConvertAll(inputStream.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
            int m = Convert.ToInt32(inputStream.ReadLine());

            int[] brr = Array.ConvertAll(inputStream.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
                ;
            int[] result = algor.missingNumbers(arr, brr);

            //textWriter.WriteLine(string.Join(" ", result));
        }
    }
}
