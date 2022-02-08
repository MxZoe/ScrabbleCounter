using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ScrabbleCounter.Models;

namespace ScrabbleCounter.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void GetUserInput_RetrievesUserInput_String()
    {
      Word newWord = new Word("word");
      string inputtedWord = "word";
      Assert.AreEqual(inputtedWord, newWord.UserInput);
    }
    [TestMethod]
    public void GetLetterPointDictionary_RetrieveLetterPointDictionary_Dictionary()
    {
      Word newWord = new Word("word");
      Dictionary<string, int> testLetterPoints = new Dictionary<string, int>();
      testLetterPoints.Add("a", 1);
      testLetterPoints.Add("b", 3);
      testLetterPoints.Add("c", 3);
      testLetterPoints.Add("d", 2);
      testLetterPoints.Add("e", 1);
      testLetterPoints.Add("f", 4);
      testLetterPoints.Add("g", 2);
      testLetterPoints.Add("h", 4);
      testLetterPoints.Add("i", 1);
      testLetterPoints.Add("j", 8);
      testLetterPoints.Add("k", 5);
      testLetterPoints.Add("l", 1);
      testLetterPoints.Add("m", 3);
      testLetterPoints.Add("n", 1);
      testLetterPoints.Add("o", 1);
      testLetterPoints.Add("p", 3);
      testLetterPoints.Add("q", 10);
      testLetterPoints.Add("r", 1);
      testLetterPoints.Add("s", 1);
      testLetterPoints.Add("t", 1);
      testLetterPoints.Add("u", 1);
      testLetterPoints.Add("v", 4);
      testLetterPoints.Add("w", 4);
      testLetterPoints.Add("x", 8);
      testLetterPoints.Add("y", 4);
      testLetterPoints.Add("z", 10);
      CollectionAssert.AreEqual(testLetterPoints, newWord.LetterPoints);
    }
  }
}

