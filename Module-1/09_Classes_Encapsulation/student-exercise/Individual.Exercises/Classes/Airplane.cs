namespace Individual.Exercises.Classes
{
    public class Airplane
    {

        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
                //AvailableFirstClassSeats is a derived property calculated by 
                //subtracting BookedFirstClassSeats from TotalFirstClassSeats.

                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                //AvailableCoachSeats is a derived property calculated by 
                //subtracting BookedCoachSeats from TotalCoachSeats.
                
                return TotalCoachSeats - BookedCoachSeats;
            }
        }

        public Airplane (string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            //If forFirstClass is true, add totalNumberOfSeats to the value for BookedFirstClassSeats.
            if (forFirstClass)
            {
                if (AvailableFirstClassSeats>=totalNumberOfSeats)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                } 
            }
            else
            {
                if (AvailableCoachSeats >= totalNumberOfSeats)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
            }
            return false;
        }
    }
}
