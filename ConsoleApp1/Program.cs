using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mapper.Initialize(x => x.CreateMap<Book, BookViewModel>().ForMember(dest=>dest.Author,opts=>opts.MapFrom(src=>src.Author.Name)));
            Book book = new Book() { Author=new Author {  Name="DS"}, Title="JJ" };
            BookViewModel model = new BookViewModel
            {
                Title = book.Title,
                Author = book.Author.Name
            };
            var m = Mapper.Map<BookViewModel>(book);
            Console.WriteLine("Author:"+m.Author+",Title:  "+m.Title);
        }
    }
    public class Author
    {
        public string Name { get; set; }
    }
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
    }
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
