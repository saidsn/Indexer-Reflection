using Homework.Models;
using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object,overroding
            //List<Book> books = new List<Book>();



            //Book book1 = new Book
            //{
            //    Id = 1,
            //    Name = "Xosrov ve Shirin",
            //    Author = "Nizami Gencevi"
            //};
            //Book book2 = new Book
            //{
            //    Id = 2,
            //    Name = "7 Gozel",
            //    Author = "Nizami Gencevi"
            //};
            //Book book3 = new Book
            //{
            //    Id = 3,
            //    Name = "Isgendername",
            //    Author = "Nizami Gencevi"
            //};

            //books.Add(book1);
            //books.Add(book2);
            //books.Add(book3);

            ////Console.WriteLine(GetBookById(books,3));


            ////Console.WriteLine(GetBooksById(1,books));

            //var result = GetBooksById(3, books);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Student> students = new List<Student>();

            //Student student1 = new Student
            //{
            //    Telebecode = 11,
            //    Name = "Seid",
            //    Surname = "Nuraliyev"
            //};
            //Student student2 = new Student
            //{
            //    Telebecode = 17,
            //    Name = "Ali",
            //    Surname = "Aliyev"
            //};
            //Student student3 = new Student
            //{
            //    Telebecode = 23,
            //    Name = "Emil",
            //    Surname = "Abdullayev"
            //};

            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);

            ////Console.WriteLine(student3);


            ////Console.WriteLine(GetStudentByCode(23, students));



            //var result = GetStudentsByCode(17, students);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Indexer
            //Book book = new Book
            //{
            //    Id = 1,
            //    Name = "Xosrov ve Shirin",
            //    Author = "Nizami Gencevi"
            //};

            //Library library = new Library();
            //library[0] = book;
            //Console.WriteLine(library[0]);
            #endregion


        }
        #region Object,overroding
        //public static Book GetBookById(List<Book> book, int id)
        //{
        //    return book.Find(m => m.Id == id);
        //}
        //public static List<Book> GetBooksById(int id, List<Book> books)
        //{
        //    return books.FindAll(m => m.Id != id);
        //}




        //public static Student GetStudentByCode(int TelebeCode, List<Student> student)
        //{
        //    return student.Find(m => m.Telebecode == TelebeCode);
        //}

        //public static List<Student> GetStudentsByCode(int TelebeCode, List<Student> students)
        //{
        //    return students.FindAll(m => m.Telebecode != TelebeCode);
        //}
        #endregion





    }
    
}