namespace CountdownTask.ConsoleApp
{
    using System;

    public class FirstTestClass
    {
        public string Name { get; set; }

        public FirstTestClass(string name)
        {
            this.Name = name;
        }

        public void WriteAMessage(object sender, TimeIsOverEventArgs eventArgs)
        {
            Console.WriteLine($"{eventArgs.Message}. First test message.");
        }
    }
}
