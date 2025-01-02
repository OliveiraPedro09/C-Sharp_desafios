class BankAccount(){
    public int AccountNumber;
    public string Owner = string.Empty;
    public double Balance;
    private string password = string.Empty;

    public void ShowAccount(){
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Owner: " + Owner);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Car(){
    public void Accelerate(){
        Console.WriteLine("Car is accelerating");
    }

    public void Brake(){
        Console.WriteLine("Car is braking");
    }

    public void Honk(){
        Console.WriteLine("Car is honking");
    }
}

