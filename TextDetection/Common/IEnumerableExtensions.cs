using System;
using System.Collections.Generic;

namespace TextDetection.Common
{
    public static class IEnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> onItem)
        {
            foreach (var item in enumerable)
                onItem(item);
        }
    }
}
