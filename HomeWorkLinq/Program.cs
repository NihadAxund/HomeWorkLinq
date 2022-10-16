using HomeWorkLinq;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var db = new LibraryContext())
            {
                var authors = db.Authors.ToList();
                ShowAuthorsCount(authors);
                SumAuthors(authors);
                MinAuthors(authors);
                MaxnAuthors(authors);
                AverageAuthors(authors);
            }
        }
        static void AverageAuthors(List<Author> authors)
        {
            Console.WriteLine($"Authors Count:  {authors.Average(x => x.Id)}\n");
        }
        static void MinAuthors(List<Author> authors)
        {
            Console.WriteLine($"Authors Count:  {authors.Min(x => x.Id)}\n");
        }
        static void MaxnAuthors(List<Author> authors)
        {
            Console.WriteLine($"Authors Count:  {authors.Max(x => x.Id)}\n");
        }
        static void ShowAuthorsCount(List<Author> authors)
        {
            Console.WriteLine( $"Authors Count:  {authors.Count(x => x.Id > 0)}\n");
        }
        static void SumAuthors(List<Author> authors)
        {
            Console.WriteLine($"Authors Sum:  {authors.Sum(x => x.Id)}\n");
        }
        static void ShowAuthors(List<Author> autors)
        {
            foreach (var autor in autors)
            {
                Console.WriteLine($"{autor.Id}. {autor.FirstName} {autor.LastName}");
            }
        }
    }
}
