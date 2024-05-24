using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarrior.Collections
{
  [TestClass]
  public class IntComparerTest
  {
    private readonly IComparer<int> Comparer = new IntComparer();

    [TestMethod]
    public void ZeroOnEquals()
    {
      Assert.AreEqual(0, Comparer.Compare(42, 42));
    }

    [TestMethod]
    public void NegativeOnLessThan()
    {
      Assert.IsTrue(Comparer.Compare(1, 2) < 0);
    }

    [TestMethod]
    public void PositiveOnGreaterThan()
    {
      Assert.IsTrue(Comparer.Compare(2, 1) > 0);
    }
  }
}
