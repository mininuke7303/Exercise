namespace EventsAndDelegates {

    public delegate void CarSpeedChanged(int prevSpeed, int currentSpeed);


    public class Car {

        public CarSpeedChanged SpeedChanged;

        public string Make { get; set; }

        public string Model { get; set; }
        public int CurrentSpeed { get; protected set; } = 0;

        public void Accelerate() {
            int prevSpeed = CurrentSpeed;
            CurrentSpeed += 5;
            if(SpeedChanged != null) {
                SpeedChanged.Invoke(prevSpeed, CurrentSpeed);
            }
        }
    }
}
