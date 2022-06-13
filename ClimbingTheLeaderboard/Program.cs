// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> iRanked = new(new[] { 100, 100, 50, 40, 20, 10});
List<int> iScore = new(new[] { 5, 25, 50, 120});

Console.WriteLine(String.Join(" ; ", ClimbingTheLeaderboard.ClimbingTheLeaderboard.climbingLeaderboard(iRanked, iScore).Select(x => x.ToString())));