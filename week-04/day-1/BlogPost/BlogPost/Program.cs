using System;

namespace BlogPost
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogpost1 = new BlogPost();
            blogpost1.AuthorName = "John Doe";
            blogpost1.Title = "Lorem Ipsum";
            blogpost1.Text = "Lorem ipsum dolor sit amet.";
            blogpost1.PublicationDate = "2000.05.04.";

            BlogPost blogpost2 = new BlogPost();
            blogpost2.AuthorName = "Tim Urban";
            blogpost2.Title = "Wait but why";
            blogpost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogpost2.PublicationDate = "2010.10.10.";

            BlogPost blogPost3 = new BlogPost();
            blogPost3.AuthorName = "William Turton";
            blogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            blogPost3.PublicationDate = "2017.03.28.";

            Console.WriteLine(blogPost3.Text);
            Console.ReadLine();
        }
    }
}
