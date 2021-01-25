namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        public Elevator(int numberOfLevels)
        {
            this.NumberOfLevels = numberOfLevels;
            this.CurrentLevel = 1;
        }
        public void OpenDoor()
        {
            this.DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            this.DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            //sends the elevator upward to the desired floor
            // as long as the door isn't open. 
            // Can't go past top floor.

            if (!DoorIsOpen && desiredFloor<=this.NumberOfLevels && desiredFloor>this.CurrentLevel )
                                        
            {
                this.CurrentLevel = desiredFloor;
            }
        }
        public void GoDown(int desiredFloor)
        {
            //sends the elevator downward to the desired floor
            //as long as the door isn't open.
            //Can't go past floor one.
            if (!DoorIsOpen && desiredFloor >0 && desiredFloor < CurrentLevel)
            {
                CurrentLevel = desiredFloor;
            }

        }
    }

}
