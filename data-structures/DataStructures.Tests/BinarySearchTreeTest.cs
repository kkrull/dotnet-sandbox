using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarrior.Collections
{
  [TestClass]
  public sealed class BinarySearchTreeTest
  {
    private readonly BinarySearchTree<int> Tree = new BinarySearchTree<int>(new IntComparer());

    [TestMethod]
    public void InitializesEmpty()
    {
      Assert.AreEqual(0, Tree.GetKeys().Count);
    }

    [TestMethod]
    public void GetsSingleKey()
    {
      Tree.Add(42);
      AssertAreEqual(new int[] { 42 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddIgnoresDuplicateKey()
    {
      Tree.Add(42).Add(42);
      AssertAreEqual(new int[] { 42 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddLeftChild()
    {
      Tree.Add(3).Add(1);
      AssertAreEqual(new int[] { 1, 3 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddLeftGrandchild()
    {
      Tree.Add(3).Add(1).Add(0);
      AssertAreEqual(new int[] { 0, 1, 3 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddRightChild()
    {
      Tree.Add(3).Add(4);
      AssertAreEqual(new int[] { 3, 4 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddRightGrandchild()
    {
      Tree.Add(3).Add(4).Add(5);
      AssertAreEqual(new int[] { 3, 4, 5 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddSimpleRightSubtree()
    {
      Tree.Add(9).Add(4).Add(2).Add(3);
      AssertAreEqual(new int[] { 2, 3, 4, 9 }, Tree.GetKeys());
    }

    [TestMethod]
    public void AddComplexRightSubtree()
    {
      Tree.Add(9).Add(4).Add(2).Add(1).Add(3).Add(8).Add(6).Add(5).Add(7);
      AssertAreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, Tree.GetKeys());
    }

    /* Assertions */

    private void AssertAreEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual)
    {
      IList<T> expectedList = expected.ToList(), actualList = actual.ToList();
      try
      {
        Assert.AreEqual(expectedList.Count, actualList.Count);
        for (int i = 0; i < expectedList.Count; i++)
          Assert.AreEqual(expectedList[i], actualList[i], "Mismatch at element {0}".InvariantFormat(i));
      }
      catch (AssertFailedException e)
      {
        string details = "Expected <{0}> but was <{1}>.  Caused by: {2}"
          .InvariantFormat(string.Join(",", expectedList), string.Join(",", actualList), e.Message);
        throw new AssertFailedException(details, e);
      }
    }
  }
}
