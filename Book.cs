namespace Week3_Encapsulation
{
    class Book
    {
        private string title; // private field
        private string author;// private field
        private string isbn; // private field   

        // Title property to allow access
        // to the title private field

        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }
        public string Author
        {   
            get { return author; } // get method
            set
            {
                // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");

                }
            }
        }
        public string ISBN
        {
            get { return isbn; } // get method

            set
            {
                // Checks that the incoming string is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");

                }
            }
        }

        // Constructor to add a new book    
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // Method to display information about a book

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}

///The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
// declare fields/variables as private
// provide public get and set methods, through properties, to access and update the value of a private variable