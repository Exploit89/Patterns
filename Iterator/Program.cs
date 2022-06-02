﻿using System;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }

    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }

    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
    class Book
    {
        public string Name { get; set; }
    }

    class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
            new Book{Name="Война и мир"},
            new Book {Name="Отцы и дети"},
            new Book {Name="Вишневый сад"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
    class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index = 0;
        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];
        }
    }
}
