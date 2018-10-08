
using System.Collections.Generic;

namespace lghtClasses
{
    public class Library 
    {
        // public Library (List<Book> initialInventory) {
        //     _bookList = initialInventory;
        // }

        private List<Book> _bookList = new List<Book>();

        public void AddBook(Book NewBook ) {
            _bookList.Add(NewBook);
        }
        public string Name { get; set;}
        public string Address { get; set;}

        public void Checkout(string isbn, CardHolder cardholder) {
            // Book foundBook = new Book();
            // bool didFindBook = false;

            foreach(Book book in _bookList) {
                if(book.ISBN == isbn && book.IsAvailable) {
                    cardholder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }

            // if (didFindBook) {}

        }

        public bool IsAvailable(string isbn) {

            foreach (Book book in _bookList) {
                if (book.ISBN == isbn) {
                    return book.IsAvailable;
                }
            }
            return false;
        }

    }

}