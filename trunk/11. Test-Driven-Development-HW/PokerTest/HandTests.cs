using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void ToStringWithNoCard()
        {
            Hand hand = new Hand(new List<ICard>());
            string result = hand.ToString();
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ToStringWithOneCard()
        {
            Hand hand = new Hand(new List<ICard>(){new Card(CardFace.Ten, CardSuit.Clubs)});
            string result = hand.ToString();
            Assert.AreEqual("10♣", result);
        }

        [TestMethod]
        public void ToStringWithThreeCards()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs)
            });
            string result = hand.ToString();
            Assert.AreEqual("3♦ A♥ 7♣", result);
        }

        [TestMethod]
        public void ToStringWithFiveCards()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });
            string result = hand.ToString();
            Assert.AreEqual("3♦ A♥ 7♣ 9♠ 10♣", result);
        }
    }
}
