namespace LibraryProject
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }
        public string Id { get; set; }
    }

    class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddNewBook(string bookTitle, string bookISBN, string bookAuthor)
        {
            Book book = new Book()
            {
                Id = Guid.NewGuid().ToString(),
                Title = bookTitle,
                ISBN = bookISBN,
                Availability = true,
                Author = bookAuthor
            };
            Books.Add(book);
            Console.WriteLine($"Book added: {book.Title} by {book.Author}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int userEnter;

            do
            {
                Console.WriteLine("Welcome to Our Library");
                Console.WriteLine("1- Add a new book to the system");
                Console.WriteLine("2- Search for a book");
                Console.WriteLine("3- Borrow a book");
                Console.WriteLine("4- Return a book");
                Console.WriteLine("5- view our books");
                Console.WriteLine("6- Quit");
                userEnter = int.Parse(Console.ReadLine());

                switch (userEnter)
                {
                    case 1:
                        Console.WriteLine("Enter the title of the book");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the name of the author of the book");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter the ISBN of the book");
                        string isbn = Console.ReadLine();
                        if(library.Books.Count != 0)
                        {
                            bool inOurLib = false;
                            foreach (Book item in library.Books)
                            {
                                if (item.Title == title)
                                    inOurLib = true;
                            }

                            if(inOurLib)
                                Console.WriteLine("the book in our liberary we can not add it kindly try to add another one");
                            else library.AddNewBook(title, isbn, author);
                        }
                        else
                        {
                        library.AddNewBook(title, isbn, author);
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("kindly enter the book title u need to search for");
                        string bookTitle = Console.ReadLine();
                        foreach (Book item in library.Books)
                        {
                            if(item.Title == bookTitle)
                            {
                                Console.WriteLine($"the book you are looking for is written by {item.Author} and the isbn is {item.ISBN}");
                            }
                            else
                            {
                                Console.WriteLine("the book u are searching for not avail right now but we will work to ad it ad if you need to add it u can do that");
                            }
                        }
                        
                        break;
                     case 3:
                        Console.WriteLine("kindly enter the book title u need to search for");
                        string book = Console.ReadLine();
                        foreach (Book item in library.Books)
                        {
                            if(item.Title == book &&  item.Availability == false)
                                Console.WriteLine("the book is borrowed now and once available we will let you know by email!!");
                           else if (item.Title == book && item.Availability == true)
                            {
                                Console.WriteLine($"the book you are looking for is written by {item.Author} and the isbn is {item.ISBN} and it's in ur account now");
                                item.Availability = false;
                            }
                            else
                            {
                                Console.WriteLine("the book u are searching for not avail right now but we will work to ad it ad if you need to add it u can do that");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("kindly enter the book title u need to search for");
                        string returnBook = Console.ReadLine();
                        foreach (Book item in library.Books)
                        {
                            if (item.Title == returnBook && item.Availability == false)
                            {
                                Console.WriteLine("Thank u for returning the book");
                                item.Availability = true;
                            }
                            
                            else if (item.Title == returnBook && item.Availability == true)
                            {
                                Console.WriteLine("book is not borrowed yet and if u need it u can borrow it!! ");
                            }
                        }
                        break;
                    case 5:
                        if(library.Books.Count == 0)
                        {

                            Console.WriteLine("no books added yet");
                        }
                        else
                        {
                            foreach (Book item in library.Books)
                                Console.WriteLine($"book {item.Title} written by {item.Author}");
                        }
                       
                        break;
                    case 6:
                        Console.WriteLine("good bye");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            while (userEnter != 6);
        }
    }
}