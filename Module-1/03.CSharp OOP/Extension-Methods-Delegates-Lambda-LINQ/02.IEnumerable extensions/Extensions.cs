namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        /// <summary>
        /// Returns the sum of a sequence of elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
       public static T Sum<T>(this IEnumerable<T> collection) where T : struct
       {
           T result = (dynamic)0;

           foreach (T item in collection)
           {
               result += (dynamic)item;
           }

           return result;
       }
        /// <summary>
       /// Returns the product of a sequence of elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
       public static T Product<T>(this IEnumerable<T> collection)where T : struct

       {
           T result = (dynamic)1;

           foreach (T item in collection)
           {
               result *= (dynamic)item;
           }

           return result;
       }
        /// <summary>
       /// Returns the minimal element of a sequence of comparable elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
       public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
       {
           dynamic result = null;

           foreach (var item in collection)
           {
               result = item;
               break;
           }

           foreach (var item in collection)
           {
               if (result.CompareTo(item)>0)
               {
                   result = item;
               }
           }
           return result;
       }
        /// <summary>
       /// Returns the maximal element of a sequence of comparable elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
       public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
       {
           dynamic result = null;

           foreach (var item in collection)
           {
               result = item;
               break;
           }

           foreach (var item in collection)
           {
               if (result.CompareTo(item) < 0)
               {
                   result = item;
               }
           }
           return result;
       }
        /// <summary>
       /// Returns the average of a sequence of elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T Average<T>(this IEnumerable<T> collection) where T : struct
        {
            T avrg = (dynamic)0;
            foreach (var item in collection)
            {
                avrg += (dynamic)item;
            }
            avrg = (dynamic)avrg / collection.Count();
            return avrg;
        }
    }
}
