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
            CurrentLevel = 1;
        }
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            //sends the elevator upward to the desired floor
            // as long as the door isn't open. 
            // Can't go past top floor.

            if (!DoorIsOpen && desiredFloor<=NumberOfLevels && desiredFloor>CurrentLevel )
            {
                CurrentLevel = desiredFloor;
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
