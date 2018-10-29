using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

    
        public string Author
        {
            get { return author; }
            set
            {
                var val = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (val.Length > 1)
                {
                    string firstName = val[0];
                    string lastName = val[1];
                    if (Char.IsDigit(lastName[0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                    this.author = value;
                }
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\nTitle: {this.Title}\nAuthor: {this.Author}\nPrice: {this.Price:f2}";
        }
    }
}
