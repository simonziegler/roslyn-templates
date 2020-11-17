﻿using System.Collections.Generic;

namespace Tests_MyTemplate.Helpers
{
    public static class Extensions
    {
        public static IEnumerable<T> Without<T>(this IEnumerable<T> source, T value)
        {
            foreach (var item in source)
            {
                if (!item?.Equals(value) ?? value is not null)
                {
                    yield return item;
                }
            }
        }
    }
}