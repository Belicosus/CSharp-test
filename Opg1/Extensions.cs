using System;
using System.Collections.Generic;
using System.Linq;

namespace Opg1
{
    /// <summary>
    /// Implement the missing method(s).
    /// Your implementation must pass as many tests as possible.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Find the nearest to a given value and return it.
        /// If multiple matches are found the first is returned.
        /// </summary>
        /// <param name="list">List to look through.</param>
        /// <param name="value">Value to find nearest for.</param>
        /// <returns>The nearest value.</returns>
        public static int? FindNearest(this IEnumerable<int> list, int value)
        {
            int returnValue = Int32.MaxValue;
            var currentBestDelta = Int32.MaxValue;

            foreach (var i in list)
            {
                var delta = Math.Abs(i - value);

                if (delta < currentBestDelta)
                {
                    currentBestDelta = delta;
                    returnValue = i;
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Find a node that satisfy a given predicate and return it.
        /// </summary>
        /// <typeparam name="T">Type of <see cref="Node{T}"/>.</typeparam>
        /// <param name="node">The current node.</param>
        /// <param name="predicate">The given predicate to satisfy.</param>
        /// <param name="next">Child selector.</param>
        /// <returns>Node satisfying the condtion, else null</returns>
        public static Node<T> FindWhere<T>(this Node<T> node, Func<Node<T>, bool> predicate, Func<Node<T>, IEnumerable<Node<T>>> next)
        {
            foreach (var i in next(node))
            {
                //If the note matches, simply return it:
                if (predicate(i))
                    return i;

                //If it doesn't, proceed to look in the children:
                foreach (var node1 in next(i))
                {
                    if (predicate(node1))
                        return node1;
                }

                //If we get here, we didn't get a match on the first note, continue to next note (via foreach)
            }

            //We are out of luck
            return null;
        }
    }
}
