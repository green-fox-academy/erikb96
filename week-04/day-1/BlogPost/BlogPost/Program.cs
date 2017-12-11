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
            BlogPost blogpost1;
            blogpost1.AuthorName = "John Doe";
            blogpost1.Title = "Lorem Ipsum";
            blogpost1.Text = "Lorem ipsum dolor sit amet.";
            blogpost1.PublicationDate = "2000.05.04.";

            BlogPost blogpost2;
            blogpost2.AuthorName = "Tim Urban";
            blogpost2.Title = "Wait but why";
            blogpost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blogpost2.PublicationDate = "2010.10.10.";

            BlogPost blogPost3;
            blogPost3.AuthorName = "";
            blogPost3.Title = "";
            blogPost3.Text = "";
            blogPost3.PublicationDate = "";
        }
    }
}
