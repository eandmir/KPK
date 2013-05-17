using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int CardsInAHand = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != CardsInAHand)
            {
                return false;
            }
            else if (this.ThereAreDuplicatedCards(hand))
            {
                return true;
            }
            else return false;
        }

        public bool ThereAreDuplicatedCards(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count-1; i++)
            {
                for (int j = i+1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face.Equals(hand.Cards[j].Face) &&
                        hand.Cards[i].Suit.Equals(hand.Cards[j].Suit))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsFlush(IHand hand)
        {
            for (int i =  1; i < hand.Cards.Count; i++)
            {
                if (!hand.Cards[1].Suit.Equals(hand.Cards[i].Suit))
                {
                    return false;
                }
            }

           return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int counter = 1;

            for (int i = 1; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[0].Face.Equals(hand.Cards[i].Face))
                {
                    counter++;
                }
            }

            if (counter == 4)
            {
                return true;
            }
            else
            {
                counter = 1;

                for (int i = 2; i < hand.Cards.Count; i++)
                {
                    if (hand.Cards[1].Face.Equals(hand.Cards[i].Face))
                    {
                        counter++;
                    }
                }

                if (counter == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
