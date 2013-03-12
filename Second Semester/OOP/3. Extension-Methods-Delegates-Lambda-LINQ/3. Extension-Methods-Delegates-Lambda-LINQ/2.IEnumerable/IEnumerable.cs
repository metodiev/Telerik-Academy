//
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IEnumerable
{
    //Ienumerable class
    public static class IEnumerable
    {
        //Extension method Sum
        public static T Sum<T>(this IEnumerable<T> items) where T : IComparable
        {
            //ArrayList sum = new ArrayList();

            dynamic sumFunction = null;

            foreach (var item in items)
            {
                sumFunction += items;
            }
            return sumFunction;
        }

        //Extension method Product 
        public static T Product<T>(this IEnumerable<T> items) where T : IComparable
        {
            //ArrayList sum = new ArrayList();

            dynamic productFunction = null;

            foreach (var item in items)
            {
                productFunction *= items;
            }
            return productFunction;
        }

        //Extension method Min
        public static double Min<T>(this IEnumerable<double> source) where T : IEnumerable
        {
            //ArrayList sum = new ArrayList();
            double min = source.Min();
            return min;
        }

        //Extension method Max
        public static double Max<T>(this IEnumerable<double> source) where T : IEnumerable
        {
            //ArrayList sum = new ArrayList();
            double max = source.Max();
            return max;
        }


        //Extension method Average
        public static decimal Average<T>(this IEnumerable<decimal> source) where T : IEnumerable
        {
            //ArrayList sum = new ArrayList();
            decimal count = source.Count();
            return count;
        }

    }
}

