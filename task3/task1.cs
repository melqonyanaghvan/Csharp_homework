using System;

class Contact{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public void DisplayInfo(){
        Console.WriteLine($"Contakt:\nName: {Name}\nPhone: {PhoneNumber}\nEmail: {Email}");
    }
}

class Program{
    static void Main(){
           
        Contact[] contact = new Contact[3];

        for (int i = 0; i < 3; i++){
            contact[i] = new Contact();

            Console.WriteLine($"\nEnter contact information: number {i + 1}:");

            Console.Write("Enter name: ");
            contact[i].Name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            contact[i].PhoneNumber = Console.ReadLine(); 
            
            Console.Write("Enter Email: ");
            contact[i].Email = Console.ReadLine();
        }

        Console.WriteLine("\nEnter contact name for search:");
        string search = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < 3; i++){
            if (search.Equals(contact[i].Name, StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine($"\nContact is found :number {i + 1}:");
                contact[i].DisplayInfo();
                found = true;
                break;
            }
        }

        if (!found){
            Console.WriteLine("Contact is not found.");
        }
    }
}


