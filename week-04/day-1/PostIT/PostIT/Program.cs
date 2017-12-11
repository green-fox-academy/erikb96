using System;

namespace PostIT
{
    class Program
    {
        struct PostIt
        {
            public string BackgroundColor;
            public string Text;
            public string TextColor;
        }
        static void Main(string[] args)
        {
            PostIt postIT1;
            postIT1.BackgroundColor = "orange";
            postIT1.Text = "Idea1";
            postIT1.TextColor = "blue";

            PostIt postIT2;
            postIT2.BackgroundColor = "pink";
            postIT2.Text = "Awesome";
            postIT2.TextColor = "black";

            PostIt postIT3;
            postIT3.BackgroundColor = "yellow";
            postIT3.Text = "Superb";
            postIT3.TextColor = "green";

            Console.WriteLine(postIT2.Text);
            Console.ReadLine();




        }
    }
}
