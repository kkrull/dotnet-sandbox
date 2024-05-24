using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CodeWarrior.Collections
{
  public static class Extensions
  {
    public static string InvariantFormat(this string format, params object[] elements)
    {
      return string.Format(CultureInfo.InvariantCulture, format, elements);
    }

    public static void AddAll<T>(this IList<T> list, IEnumerable<T> elements)
    {
      foreach (T element in elements)
        list.Add(element);
    }
  }
}
