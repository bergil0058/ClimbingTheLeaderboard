using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderboard
{
    public class ClimbingTheLeaderboard
    {

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player) // > a < y < a > respectivamente
        {
            List<int> iRetVal = new();
            Dictionary<int, int> iResultDic = new();

            List<int> iRanked = ranked.Distinct().ToList();
            int iPlayerLenght = player.Count;
            int iRankedLenght = iRanked.Count;
            int j = 0;

            for (int i = 0; i < iPlayerLenght; i++) // De < a >
            {
                int iResultItem;
                int iScore = player[i];
                if(iResultDic.ContainsKey(iScore))
                {
                    iResultItem = iResultDic[iScore];
                }
                else
                {
                    iResultItem = GetPositionInRankedArray(iRanked, iRankedLenght, iScore, ref j);
                    iResultDic.Add(iScore, iResultItem);
                }                
                iRetVal.Add(iResultItem);
            }

            return iRetVal;
        }


        private static int GetPositionInRankedArray(List<int> aRanked, int aRankedLenght, int aScore, ref int j)
        {
            int iRetVal;

            // De < a > (der => izq)
            while (j < aRankedLenght && aRanked[aRankedLenght - 1 - j] <= aScore)
            {
                j++;
            }
            iRetVal = aRankedLenght - j + 1;

            return iRetVal;
        }

    }
}
