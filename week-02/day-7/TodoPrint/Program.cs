using System;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk \n";
            todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(todoText.LastIndexOf("\n"), "\n - Download games");
            todoText = todoText.Insert(todoText.LastIndexOf("\n"), "\n - Diablo");
            Console.WriteLine(todoText);
            Console.ReadLine();

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(todoText);
        }
    }
}