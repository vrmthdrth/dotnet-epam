namespace CountdownTask.ConsoleApp
{
    using System;

    public class SecondTestClass
    {
        public string Name { get; set; }

        public SecondTestClass(string name)
        {
            this.Name = name;
        }

        public void WriteAMessage(object sender, TimeIsOverEventArgs eventArgs)
        {
            Console.WriteLine($"{eventArgs.Message}. Second test message.");
        }
    }
}
