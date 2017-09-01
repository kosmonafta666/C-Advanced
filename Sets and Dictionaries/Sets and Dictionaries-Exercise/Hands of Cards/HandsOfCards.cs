namespace Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HandsOfCards
    {
        public static void Main(string[] args)
        {
            //dictionary for players;
            var players = new Dictionary<string, HashSet<string>>();

            //read the input commands;
            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                //var for splited input;
                var tokens = input
                    .Split(':');

                //var for players name;
                var playersName = tokens[0];
                //list for cards;
                var cards = tokens[1]
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();

                //fill the dictionary;
                if (players.ContainsKey(playersName))
                {
                    players[playersName].UnionWith(cards);
                }
                else
                {
                    players[playersName] = new HashSet<string>(cards);
                }


                input = Console.ReadLine();
            }//end fo while loop;

            //print the result;
            PrintAllPlayers(players);
        }

        //method to print result;
        public static void PrintAllPlayers(Dictionary<string, HashSet<string>> players)
        {
            foreach (var player in players)
            {
                //var for player score;
                var score = CalculatePlayerScore(player.Value);

                Console.WriteLine("{0}: {1}", player.Key, score);
            }
        }

        //method to calculate the score for every player;
        public static int CalculatePlayerScore(HashSet<string> cards)
        {
            //var for total score;
            var totalScore = 0;

            foreach (var card in cards)
            {
                //var for power of card;
                var power = card.Substring(0, card.Length - 1);
                //var for type of card;
                var type = card.Last();

                //var for current score;
                int score = 0; 

                //bool to check if power is digit;
                var isDigit = int.TryParse(power, out score);
                
                //calculate the power;
                if (!isDigit)
                {
                    switch (power)
                    {
                        case "J":
                            score = 11;
                            break;
                        case "Q":
                            score = 12;
                            break;
                        case "K":
                            score = 13;
                            break;
                        case "A":
                            score = 14;
                            break;
                    }
                }

                //calculate the final score;
                switch (type)
                {
                    case 'S':
                        score *= 4;
                        break;
                    case 'H':
                        score *= 3;
                        break;
                    case 'D':
                        score *= 2;
                        break;
                    case 'C':
                        score *= 1;
                        break;
                }

                totalScore += score;
            }

            return totalScore;
        }
    }
}
