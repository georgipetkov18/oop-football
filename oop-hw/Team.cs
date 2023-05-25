namespace oop_hw
{
    public class Team
    {
        private List<FootballPlayer> players;

        public List<FootballPlayer> Players
        {
            get { return players; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Specify a valid players value");
                }

                if (value.Count < 11)
                {
                    throw new ArgumentException("The number of players in the team must be at least 11");
                }

                if (value.Count > 22)
                {
                    throw new ArgumentException("The number of players in the team must be 22 maximum");
                }

                players = value;
            }
        }

        public Coach Coach { get; private set; }

        public double AverageAge => players.Average(x => x.Age);

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }
    }
}
