using System;

class Book {
    public string? Title { get; set; }
    public string? Author { get; set; }
    public bool IsAvailable { get; set; } = true;

    public void BorrowBook() { 
        if (IsAvailable) { 
            IsAvailable = false; 
            Console.WriteLine($"You have borrowed '{Title}' by {Author}. It is now unavailable.");
        } else { 
            Console.WriteLine($"'{Title}' is currently not available.");
        }
    }

    public void ReturnBook() { 
        if (!IsAvailable) { 
            IsAvailable = true; 
            Console.WriteLine($"You have returned '{Title}' by {Author}. It is now available.");
        } else { 
            Console.WriteLine($"'{Title}' was not borrowed, so it cannot be returned.");
        }
    }

    public void DisplayInfo() { 
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nAvailable: {(IsAvailable ? "Yes" : "No")}");
    }
}

class Program {
    static void Main() {
        Book[] library = new Book[3];
        library[0] = new Book { Title = "Lord of the Rings?", Author = "J. R. R. Tolkien" };
        library[1] = new Book { Title = "One Piece", Author = "Eichiro Oda" };
        library[2] = new Book { Title = "White Nights and Other Stories", Author = "Dostoyevsky Fyodor" };

        Console.WriteLine("Books in the library:");
        foreach (var book in library) 
            book.DisplayInfo();

        while (true) {
            Console.WriteLine("\nChoose an option:\n1. Borrow a book\n2. Return a book\n3. Display books information\n4. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                Console.WriteLine("\nChoose a book to borrow:");
                for (int i = 0; i < library.Length; i++) {
                    Console.WriteLine($"{i + 1}. {library[i].Title}");
                }

                int borrowChoice = int.Parse(Console.ReadLine()) - 1;
                if (borrowChoice >= 0 && borrowChoice < library.Length) {
                    library[borrowChoice].BorrowBook();
                } else {
                    Console.WriteLine("Invalid selection.");
                }
            } else if (choice == 2) {
                Console.WriteLine("\nChoose a book to return:");
                for (int i = 0; i < library.Length; i++) {
                    Console.WriteLine($"{i + 1}. {library[i].Title}");
                }

                int returnChoice = int.Parse(Console.ReadLine()) - 1;
                if (returnChoice >= 0 && returnChoice < library.Length) {
                    library[returnChoice].ReturnBook();
                } else {
                    Console.WriteLine("Invalid selection.");
                }
            } else if (choice == 3) {
                Console.WriteLine("\nDisplay book information:");
                for (int i = 0; i < library.Length; i++) {
                    library[i].DisplayInfo();
                    Console.WriteLine();
                }
            } else if (choice == 4) {
                Console.WriteLine("Exit.");
                break;
            } else {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}
