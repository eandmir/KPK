using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToStringOfThreeOfDiamonds()
        {
            Card card = new Card(CardFace.Three, CardSuit.Diamonds);
            string result = card.ToString();
            Assert.AreEqual("3♦", result);
        }

        [TestMethod]
        public void ToStringOfAceOfHeart()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            string result = card.ToString();
            Assert.AreEqual("A♥", result);
        }

        [TestMethod]
        public void ToStringOfSevenOfClubs()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Clubs);
            string result = card.ToString();
            Assert.AreEqual("7♣", result);
        }

        [TestMethod]
        public void ToStringOfNineOfSpades()
        {
            Card card = new Card(CardFace.Nine, CardSuit.Spades);
            string result = card.ToString();
            Assert.AreEqual("9♠", result);
        }

        [TestMethod]
        public void ToStringOfTenOfClubs()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Clubs);
            string result = card.ToString();
            Assert.AreEqual("10♣", result);
        }
    }
}
