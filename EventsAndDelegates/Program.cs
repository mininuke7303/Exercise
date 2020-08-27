using System;
using System.Threading;

namespace EventsAndDelegates {
    class Program {
        static void Main(string[] args) {

            Car c = new Car() {
                Make = "Foo",
                Model = "Bar"
            };
            c.SpeedChanged = OnCarSpeedChanged;
            c.Accelerate();
            Thread.Sleep(1000);
            c.Accelerate();

        }

        public static void OnCarSpeedChanged(int prevSpeed, int currentSpeed) {
            Console.WriteLine($"Current went from ${prevSpeed}km/h to ${currentSpeed}km/h");
        }

    }
}
