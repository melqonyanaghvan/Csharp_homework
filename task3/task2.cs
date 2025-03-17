using System;

class Student{
    public string AccountNumber { get; set; }
    public string HolderName { get; set; }
    public int Balance { get; private set; }

    public void Deposit(int amount) {
        if (amount > 0){
            Balance += amount;
            Console.WriteLine($"{amount} was added. New Balance: {Balance}");
        }
        else {
            Console.WriteLine("Error, amount must be > 0.");
        }
    }

    public void Withdraw(int amount) {
        if (amount > 0 && amount <= Balance) {
            Balance -= amount;
            Console.WriteLine($"New balance: {Balance}");
        }
        else if (amount > Balance) {
            Console.WriteLine("Not enough funds.");
        }
        else {
            Console.WriteLine("Error, amount must be > 0.");
        }
    }

    public void DisplayInfo(){
        Console.WriteLine($"\nInformation:");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Holder Name: {HolderName}");
        Console.WriteLine($"Balance: {Balance}");
    }
}


class Program{
    static void Main(){

        BankAccount bank = new BankAccount();

        Console.WriteLine("Creating bank account. Enter details:\n");

        Console.WriteLine("Enter account number:");
        bank.AccountNumber = int.Parse(Console.ReadLine());
            
        Console.WriteLine("Enter holder name:");
        bank.HolderName = Console.ReadLine();

        int initialBalance = -1; 

        while (initialBalance < 0){
            Console.WriteLine("Enter initial balance, which must be >= 0:");
            int input = int.Parse(Console.ReadLine());

            if (initialBalance >= 0) {
              
                break;
            }else {
               
                Console.WriteLine("Error, balance must be >= 0.");
            }
        }
        bank.Deposit(initialBalance);

        
        while (true) {
            Console.WriteLine("\nChoose an option: \n1. Deposit \n2. Withdraw \n3. Display Info \n4. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                Console.Write("Enter deposit amount: ");
                int depositAmount = int.Parse(Console.ReadLine());
                bank.Deposit(depositAmount);

            }
            else if (choice == 2) {
                Console.Write("Enter withdrawal amount: ");
                int.Parse(Console.ReadLine());
                bank.Withdraw(withdrawAmount);
            }
            else if (choice == "3") {
                bank.DisplayInfo();
            }
            else if (choice == "4") {
                Console.WriteLine("Exit.");
                break;
            }
            else {
                Console.WriteLine("Invalid option.");
            }
        }
    }     
    
}


