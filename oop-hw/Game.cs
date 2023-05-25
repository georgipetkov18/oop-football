namespace oop_hw
{
    public class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public Referee AssistantReferee1 { get; private set; }
        public Referee AssistantReferee2 { get; private set; }
        public List<Goal> Goals { get; private set; }
        public GameResult GameResult { get; private set; }
        public Team Winner { get; private set; }

        public Game(Team team1, Team team2, Referee referee, Referee assRef1, Referee assRef2)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assRef1;
            AssistantReferee2 = assRef2;
            Goals = new List<Goal>();
            GameResult = new GameResult(team1, team2);
        }

        public void ScoreGoal(Team team)
        {
            GameResult.UpdateScore(team);
        }

        public void ShowResults()
        {
            GameResult.ShowResults();
        }

        public void DisplayWinner()
        {
            var winner = GameResult.GetWinner();

            if (winner == null)
            {
                Console.WriteLine("The game was a draw. There is no winner");
                return;
            }

            var teamTitle = object.ReferenceEquals(winner, Team1) ? "Team 1" : "Team 2";
            Console.WriteLine($"{teamTitle} won the game");
        }
    }
}
