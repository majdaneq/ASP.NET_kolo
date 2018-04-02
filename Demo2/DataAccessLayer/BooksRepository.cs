using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Demo2.Models;

namespace Demo2.DataAccessLayer
{
    public class BooksRepository
    {
        private static List<CategoryModel> Categories = new List<CategoryModel>();

        static BooksRepository()
        {
            var a = new CategoryModel { Id = 1, Name = "Programowanie" };
            a.Books = new List<BookModel>
            {
                new BookModel {Id = 1, Title = "ASP .NET", Author = "Adam Nowak", ContactEmail = "adam.nowak@gmail.com", Isbn = "0-306-40615", CategoryModel = a},
                new BookModel {Id = 2, Title = "C#", Author = "Karol Kowalski", ContactEmail = "karol.kowalski@gmail.com", Isbn = "22-323-42635", CategoryModel = a},
                new BookModel {Id = 3, Title = "PHP", Author = "Edward Gierkowski", ContactEmail = "edziu@onet.pl", Isbn = "10-316-41115", CategoryModel = a},
                new BookModel {Id = 4, Title = "Java", Author = "Jan Nowakowski", ContactEmail = "jasiu_nowakowski@wp.pl", Isbn = "40-446-40444", CategoryModel = a}
            };
            Categories.Add(a);

            a = new CategoryModel { Id = 2, Name = "Gotowanie" };
            a.Books = new List<BookModel>
            {
                new BookModel {Id = 5, Title = "Jak zrobić jajecznicę?", Author = "Anna Geisler", ContactEmail = "anna.gei@gmail.com", Isbn = "44-406-47615", CategoryModel = a},
                new BookModel {Id = 6, Title = "101 przepisów na jajecznicę", Author = "Anna Geisler", ContactEmail = "anna.gei@gmail.com", Isbn = "44-406-47616", CategoryModel = a},
                new BookModel {Id = 7, Title = "Najlepsza jajecznica na świecie", Author = "Anna Geisler", ContactEmail = "anna.gei@gmail.com", Isbn = "44-406-47617", CategoryModel = a},
            };
            Categories.Add(a);

            a = new CategoryModel { Id = 3, Name = "Matematyka" };
            a.Books = new List<BookModel>
            {
                new BookModel {Id = 8, Title = "Podstawy analizy matematycznej 1", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1111", CategoryModel = a},
                new BookModel {Id = 9, Title = "Podstawy analizy matematycznej 2", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1112", CategoryModel = a},
                new BookModel {Id = 10, Title = "Podstawy analizy matematycznej 3", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1113", CategoryModel = a},
                new BookModel {Id = 11, Title = "Podstawy analizy matematycznej 4", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1114", CategoryModel = a},
                new BookModel {Id = 12, Title = "Podstawy analizy matematycznej 5", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1115", CategoryModel = a},
                new BookModel {Id = 13, Title = "Podstawy analizy matematycznej 6", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1116", CategoryModel = a},
                new BookModel {Id = 14, Title = "Podstawy analizy matematycznej 7", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1117", CategoryModel = a},
                new BookModel {Id = 15, Title = "Podstawy analizy matematycznej 8", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1118", CategoryModel = a},
                new BookModel {Id = 16, Title = "Podstawy analizy matematycznej 9", Author = "Wacław Frydrych", ContactEmail = "wacuś@buziaczek.pl", Isbn = "12-10-1119", CategoryModel = a}
            };
            Categories.Add(a);
        }

        public List<CategoryModel> GetCategories()
        {
            return Categories;
        }

        public CategoryModel GetCategoryById(int id)
        {
            return Categories.FirstOrDefault(c => c.Id == id);
        }

        public BookModel GetBookById(int id)
        {
            foreach (var category in Categories)
            {
                foreach (var book in category.Books)
                {
                    if (book.Id == id)
                        return book;
                }
            }

            return null;
        }

    }
}