namespace CountdownTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CountdownTimer countdownTimer = new CountdownTimer(5);
            FirstTestClass first = new FirstTestClass("first");
            SecondTestClass second = new SecondTestClass("second");

            countdownTimer.TimeIsOver += first.WriteAMessage;
            countdownTimer.TimeIsOver += second.WriteAMessage;
            countdownTimer.StartCountdown("Time lapsed");
            System.Console.ReadKey();
        }
    }
}
