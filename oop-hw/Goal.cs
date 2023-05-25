namespace oop_hw
{
    public class Goal
    {
        public int Minute { get; private set; }
        public FootballPlayer Player { get; private set; }

        public Goal(int minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
