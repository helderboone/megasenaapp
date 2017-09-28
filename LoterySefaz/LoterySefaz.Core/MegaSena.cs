using System;
using System.Collections.Generic;
using System.Linq;

namespace LoterySefaz.Core
{
    public class MegaSena : Loterry
    {
         Random random = new Random();

        /// <summary>
        /// Expose the result of sena winners, quina winners and quadra winners.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override Dictionary<string, string> Draw(Player player)
        {
            string resultDraw = string.Empty;
            string betList = string.Empty;
            string quadraWinners = string.Empty;
            string quinaWinners = string.Empty;
            string SenaWinners = string.Empty;

            var resultList = new Dictionary<string, string>();           

            betList = betList + "\n";

            var numbers = new List<int>();

            var possibleNumbers = new List<int>();

            for (int i = 1; i <= Constants.MegaSenaRange; i++)
            {
                possibleNumbers.Add(i);
            }

            var betNumbers =  from n in possibleNumbers orderby random.Next(possibleNumbers.Count) select n;

            foreach (var number in betNumbers)
            {
                if (numbers.Count == Constants.Sena)
                {
                    break;
                }

                numbers.Add(number);
            }

            //Implement drawn property from abstract class
            DrawnNumbers = numbers;

            foreach (var number in numbers)
            {
                resultDraw = resultDraw + number + " - ";
            }

            resultList.Add("Result", resultDraw);

            foreach (var bet in player.BetList)
            {
                int count = 0;

                foreach (var n in bet.Numbers)
                {
                    if (numbers.Contains(n))
                        count++;

                    betList = betList + n + " - ";
                }

                betList = betList + "\n";

                if (count == Constants.Quadra)
                {
                    var quadra = string.Empty;

                    foreach (var number in numbers)
                    {
                        quadra = quadra + number + " , ";
                    }

                    quadraWinners = quadraWinners + $"Player: {player.Name} BetId: {bet.BetId} BetDate: {bet.BetDate} Amount numbers hit:{quadra}";
                }

                else if (count == Constants.Quina)
                {
                    var quina = string.Empty;

                    foreach (var number in numbers)
                    {
                        quina = quina + number + " , ";
                    }

                    quinaWinners = quinaWinners + $"Player: {player.Name} BetId: {bet.BetId} BetDate: {bet.BetDate} Amount numbers hit:{quina}";
                }

                else if (count == Constants.Sena)
                {
                    var sena = string.Empty;

                    foreach (var number in numbers)
                    {
                        sena = sena + number + " , ";
                    }

                    SenaWinners = SenaWinners + $"Player: {player.Name} BetId: {bet.BetId} BetDate: {bet.BetDate} Amount numbers hit:{sena}";
                }
            }

            resultList.Add("Bet", betList);
            resultList.Add("Quadra", quadraWinners);
            resultList.Add("Quina", quinaWinners);
            resultList.Add("Sena", SenaWinners);

            return resultList;
        }
    }
}
