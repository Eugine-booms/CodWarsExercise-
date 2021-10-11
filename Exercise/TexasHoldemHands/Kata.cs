using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{

    public static class Kata
    {
        static private Dictionary<string, int> cardsDictionary = new Dictionary<string, int>
            {
                { "2", 2 },
                { "3", 3 },
                { "4", 4 },
                { "5", 5 },
                { "6", 6 },
                { "7", 7 },
                { "8", 8 },
                { "9", 9 },
                { "10", 10 },
                { "J", 11 },
                { "Q", 12 },
                { "K", 13 },
                { "A", 14 }
            };

        /*
                Straight-flush (five consecutive ranks of the same suit). Higher rank is better.
                Four-of-a-kind (four cards with the same rank). Tiebreaker is first the rank, then the rank of the remaining card.
            Full house (three cards with the same rank, two with another). Tiebreaker is first the rank of the three cards, then rank of the pair.
                Flush (five cards of the same suit). Higher ranks are better, compared from high to low rank.
                Straight (five consecutive ranks). Higher rank is better.
                Three-of-a-kind (three cards of the same rank). Tiebreaker is first the rank of the three cards, then the highest other rank, then the second highest other rank.
                Two pair (two cards of the same rank, two cards of another rank). Tiebreaker is first the rank of the high pair, then the rank of the low pair and then the rank of the remaining card.
                Pair (two cards of the same rank). Tiebreaker is first the rank of the two cards, then the three other ranks.
                Nothing. Tiebreaker is the rank of the cards from high to low.
         */
        public static (string type, string[] ranks) Hand(string[] holeCards, string[] communityCards)
        {
            var playerCards = ReturnPlayerHandLikeNumber(holeCards.Concat(communityCards));

            var isFlush = IsFlush(playerCards);
            if (isFlush != ("nothing", null))
            {
                var isStraightFlush = IsStraightFlush(isFlush.ranks);
                if (isStraightFlush != ("nothing", null))
                {
                    return IsStraightFlush(isFlush.ranks);
                }
                return (isFlush.type, isFlush.ranks.Take(5).ToArray());
            }
            var fullHouse = IsFullHouse(playerCards);
            if (fullHouse != ("nothing", null))
                return fullHouse;
            var fourOfKind = FourOfKind(playerCards);
            if (fourOfKind != ("nothing", null))
                return fourOfKind;
            var isStraight = IsStraight(playerCards);
            if (isStraight != ("nothing", null))
                return isStraight;
            var threeOfKind = IsThreeOfKind(playerCards);
            if (threeOfKind != ("nothing", null))
                return (threeOfKind.type, threeOfKind.ranks.Take(3).ToArray());
            var twoPair = IsPairOrTwoPair(playerCards);
            if (twoPair != ("nothing", null))
                return twoPair;


            var nothingSequenseFiveHightCard = NumbersArrayToStringArray(
                playerCards
                .Select(x => x.Item1)
                .OrderByDescending(x => x)
                .Take(5)
                );
            return ("nothing", nothingSequenseFiveHightCard);
        }
        private static (int ranks, int count)[] FindSameCard(Tuple<int, char>[] playerCards)
        {
            var mayBySameCards = playerCards
                .GroupBy(x => x.Item1)
                .Select(x => (x.Key, x.Count()))
                .OrderByDescending(x => x.Item2);
            return mayBySameCards.ToArray();


        }
        private static (string type, string[] ranks) IsFullHouse(Tuple<int, char>[] playerCards)
        {
            var sameCards = FindSameCard(playerCards);

            if (sameCards.All(x => x.count < 4))
            {
                sameCards = sameCards.Where(x => x.count < 4 && x.count > 1).ToArray();
                if (sameCards.Length > 1 && sameCards[0].count == 3)
                {
                    var fuleHouse = NumbersArrayToStringArray(sameCards.Select(x => x.ranks).Take(2));
                    return ("full house", fuleHouse);
                }

            }
            return ("nothing", null);
        }

        private static (string type, string[] ranks) IsPairOrTwoPair(Tuple<int, char>[] playerCards)
        {
            var sameCards = FindSameCard(playerCards);
            if (sameCards.All(x => x.count < 3) && sameCards.Any(x => x.count == 2))
            {
                if (sameCards.Where(x => x.count == 2).Count() > 1)
                {
                    var array = new int[3];
                    array[0] = sameCards[0].ranks;
                    sameCards[0].ranks = 0;
                    array[1] = sameCards[1].ranks;
                    sameCards[1].ranks = 0;
                    array[2] = sameCards.Select(x => x.ranks).OrderByDescending(x => x).FirstOrDefault();
                    var twoPair = NumbersArrayToStringArray(array);
                    return ("two pair", twoPair.Take(3).ToArray());
                }
                else
                {
                    var pair = NumbersArrayToStringArray(sameCards.Select(x => x.ranks));
                    return ("pair", pair.Take(4).ToArray());
                }
            }
            return ("nothing", null);
        }

        private static (string type, string[] ranks) IsThreeOfKind(Tuple<int, char>[] playerCards)
        {
            var sameCards = FindSameCard(playerCards);
            if (sameCards.All(x => x.count < 4) && sameCards.Any(x => x.count == 3))
            {
                var threeOfKind = NumbersArrayToStringArray(sameCards.Select(x => x.ranks));
                return ("three-of-a-kind", threeOfKind);
            }
            return ("nothing", null);
        }

        private static (string type, string[] ranks) FourOfKind(Tuple<int, char>[] playerCards)
        {
            var sameCards = FindSameCard(playerCards);
            if (sameCards.Any(x => x.count == 4))
            {
                var array = new int[2];
                array[0] = sameCards[0].ranks;
                sameCards[0].ranks = 0;
                array[1] = sameCards.Select(x => x.ranks).OrderByDescending(x => x).FirstOrDefault();
                var fourOfKind = NumbersArrayToStringArray(array);
                return ("four-of-a-kind", fourOfKind);
            }
            return ("nothing", null);
        }
        private static (string type, string[] ranks) IsStraight(Tuple<int, char>[] playerСards)
        {

            var sameCard = FindSameCard(playerСards);
            var hightCardInFlash = AreSequentialIncementing(sameCard.Select(x => x.ranks).OrderByDescending(x => x).ToArray());
            if (hightCardInFlash > 0)
            {
                return ("straight", NumbersArrayToStringArray(sameCard.Select(x => x.ranks).OrderByDescending(x => x).Where(x => x <= hightCardInFlash).Take(5)));
            }
            return ("nothing", null);
        }
        private static (string type, string[] ranks) IsStraightFlush(string[] flushCard)
        {
            var flushCardLikeNumber = ReturnPlayerHandLikeNumber(flushCard).Select(x => x.Item1).ToArray();
            var hightCardInFlash = AreSequentialIncementing(flushCardLikeNumber);
            if (hightCardInFlash > 0)
            {
                var straightSequens = flushCardLikeNumber
                    .Where(x => x <= hightCardInFlash)
                    .Take(5)
                    .OrderByDescending(x => x);
                return ("straight-flush", NumbersArrayToStringArray(straightSequens));
            }
            return ("nothing", null);
        }
        private static (string type, string[] ranks) IsFlush(Tuple<int, char>[] playerСards)
        {
            var mayByFlush = playerСards.GroupBy(x => x.Item2).Where(x => x.Count() >= 5);

            if (mayByFlush.Count() > 0)
            {
                var flushSequens = mayByFlush
                    .First()
                    .Select(x => x.Item1)
                    .OrderByDescending(x => x)
                    .ToArray();

                return ("flush", NumbersArrayToStringArray(flushSequens).ToArray());
            }
            return ("nothing", null);
        }

        private static Tuple<int, char>[] ReturnPlayerHandLikeNumber(IEnumerable<string> cards)
        {
            var allCards = cards
              .Select(x => Tuple.Create(cardsDictionary[x.Contains("1") ? "10" : x[0].ToString()], x.Last()))
              .OrderByDescending(x => x)
              .ToArray();
            return allCards;
        }
        internal static int AreSequentialIncementing(int[] number)
        {
            int count = 0;
            int hightCard = 0;
            for (int i = 0; i < number.Length - 1; i++)
            {
                if ((number[i] - 1) != number[i + 1])
                {
                    if (count >= 4)
                    {
                        return hightCard;
                    }
                    count = 0;
                    hightCard = number[i];
                }
                else
                {
                    if (count == 0)
                        hightCard = number[i];
                    count++;

                }
            }
            if (count >= 4)
            {
                return hightCard;
            }
            return -1;
        }
        private static string[] NumbersArrayToStringArray(IEnumerable<int> number)
        {
            return number.SelectMany(y => cardsDictionary.Where(x => x.Value == y).Select(z => z.Key))
                                              .ToArray();
        }

    }
}