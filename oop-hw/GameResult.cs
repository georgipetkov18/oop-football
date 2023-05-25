namespace oop_hw
{
    public class GameResult
    {
        private Dictionary<Team, int> results;

        public GameResult(Team team1, Team team2)
        {
            results = new Dictionary<Team, int>()
            {
                {team1, 0 },
                {team2, 0 },
            };
        }

        public GameResult(Team team1, int team1Result, Team team2, int team2Result)
        {
            results = new Dictionary<Team, int>()
            {
                {team1, team1Result },
                {team2, team2Result },
            };
        }

        public void UpdateScore(Team team)
        {
            if (!results.ContainsKey(team))
            {
                throw new ArgumentException("Team does not exist");
            }

            results[team]++;
        }

        public void ShowResults()
        {
            var scores = results.Values.ToList();
            Console.WriteLine($"Team 1  {scores[0]}:{scores[1]} Team 2");
        }

        public Team GetWinner()
        {
            var winners = results.Keys.Where(k => results[k] == results.Max(x => x.Value)).ToList();
            if (winners.Count > 1)
            {
                return winners[0];
            }

            return null;
        }
    }
}
