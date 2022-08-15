namespace PremierLeague
{
    public class Club
    {
        public string name;
        public int estDate;
        public string owner;
        public string manager;
        public string homeGround;

        //constructor
        public Club(string clubName , int clubEstDate, string clubOwner, string clubManager, string clubHomeGround)
        {
            name = clubName;
            estDate = clubEstDate;
            owner = clubOwner;
            manager = clubManager;
            homeGround = clubHomeGround;
            
        }

    }
}