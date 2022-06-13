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
            int j;

            for (int i = 0; i < iPlayerLenght; i++) // De < a >
            {
                int iScore = player[i];
                int iResultItem;
                if(iResultDic.ContainsKey(iScore))
                {
                    iResultItem = iResultDic[iScore];
                }
                else
                {
                    j = 0;
                    while (j < iRankedLenght && iRanked[j] > iScore) // De > a <
                    {
                        j++;
                    }
                    iResultItem = j + 1;
                    iResultDic.Add(iScore, iResultItem);
                }                
                iRetVal.Add(iResultItem);
            }

            return iRetVal;
        }

    }
}
