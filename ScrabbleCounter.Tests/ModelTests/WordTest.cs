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
  }
}

