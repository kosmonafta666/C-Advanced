namespace Number_Wars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class NumberWars
    {
        public static void Main(string[] args)
        {
            //read the first playes cards;
            var firstStr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //read the second players cards;
            var secondStr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //queue for first player;
            var firstPlayer = new Queue<string>(firstStr);

            //queue for second player;
            var secondPlayer = new Queue<string>(secondStr);

            //var count for turns;
            var turns = 0;

            //regex for digit match in the card
            var digitRegex = new Regex(@"\d+");          

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {                
                //increase the turns;
                turns++;

                //in case 1_000_000 turns;
                if (turns > 1000000)
                {
                    if (firstPlayer.Count > secondPlayer.Count)
                    {
                        Console.WriteLine("First player wins after 1000000 turns");
                    }
                    else
                    {
                        Console.WriteLine("Second player wins after 1000000 turns");
                    }
                }

                //current card of the first player;
                var card1 = firstPlayer.Dequeue();

                //current card of the second player;
                var card2 = secondPlayer.Dequeue();

                //var for value of the first card;
                var digit1 = int.Parse(digitRegex.Match(card1).ToString());
                
                //var for value of the second card;
                var digit2 = int.Parse(digitRegex.Match(card2).ToString());


                if (digit1 > digit2)
                {   
                    firstPlayer.Enqueue(card1);

                    firstPlayer.Enqueue(card2);
                }
                else if (digit1 < digit2)
                {                   
                    secondPlayer.Enqueue(card2);

                    secondPlayer.Enqueue(card1);
                }
                else if (digit1 == digit2)
                {                    
                    var flag = true;

                    while (flag)
                    {
                        var sum1 = firstPlayer.Take(3).Sum(x => (int)x.ToUpper().Last() - 64);

                        var sum2 = secondPlayer.Take(3).Sum(x => (int)x.ToUpper().Last() - 64);

                        if (sum1 > sum2)
                        {
                            var secondCards = secondPlayer.Take(3).ToList();

                            foreach (var card in secondCards.OrderByDescending(x => x))
                            {
                                firstPlayer.Enqueue(card);
                            }

                            for (int i = 0; i < 3; i++)
                            {
                                secondPlayer.Dequeue();
                            }
                           
                            flag = false;
                        }
                        else if (sum1 < sum2)
                        {
                            var firstCards = secondPlayer.Take(3).ToList();

                            foreach (var card in firstCards.OrderByDescending(x => x))
                            {
                                secondPlayer.Enqueue(card);
                            }

                            for (int i = 0; i < 3; i++)
                            {
                                firstPlayer.Dequeue();
                            }
                            
                            flag = false;
                        }
                        else if (sum1 == sum2)
                        {
                           
                            if (firstPlayer.Count == 0 && secondPlayer.Count == 0)
                            {
                                flag = false;
                            }

                            var remainingFirst = firstPlayer.Take(3).ToList();


                            foreach (var item in remainingFirst)
                            {
                                firstPlayer.Dequeue();
                            }

                            var remainigSecond = secondPlayer.Take(3).ToList();

                            foreach (var item in remainigSecond)
                            {
                                secondPlayer.Dequeue();
                            }
                        }
                    }
                    
                }
               
            }//end of the while loop;

            if (firstPlayer.Count > 0)
            {
                Console.WriteLine("First player wins after {0} turns", turns);
            }
            else if (secondPlayer.Count > 0)
            {
                Console.WriteLine("Second player wins after {0} turns", turns);
            }
            else
            {
                Console.WriteLine("Draw after {0} turns", turns);
            }
        }
    }
}
