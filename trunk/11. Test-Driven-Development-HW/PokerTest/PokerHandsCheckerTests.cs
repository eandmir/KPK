using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void IsValidHandTrue()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsValidHand(hand);
            Assert.IsTrue(isValidHand);
        }

        [TestMethod]
        public void IsValidHandFalseDuplicated()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsValidHand(hand);
            Assert.IsFalse(isValidHand);
        }

        [TestMethod]
        public void IsValidHandFalseLessCards()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsValidHand(hand);
            Assert.IsFalse(isValidHand);
        }

        [TestMethod]
        public void IsFourOfAKindTrue()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs)
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsFourOfAKind(hand);
            Assert.IsTrue(isValidHand);
        }

        [TestMethod]
        public void IsFlushTrue()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsFlush(hand);
            Assert.IsTrue(isValidHand);
        }

        [TestMethod]
        public void IsFlushFalse()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsFlush(hand);
            Assert.IsFalse(isValidHand);
        }

        [TestMethod]
        public void IsFourOfAKindTrueCons()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsFourOfAKind(hand);
            Assert.IsTrue(isValidHand);
        }

        [TestMethod]
        public void IsFourOfAKindTrueMix()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsFourOfAKind(hand);
            Assert.IsTrue(isValidHand);
        }

        [TestMethod]
        public void IsFourOfAKindFalse()
        {
            Hand hand = new Hand(new List<ICard>() 
            { 
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });

            PokerHandsChecker checkHand = new PokerHandsChecker();
            bool isValidHand = checkHand.IsFourOfAKind(hand);
            Assert.IsFalse(isValidHand);
        }
    }
}
