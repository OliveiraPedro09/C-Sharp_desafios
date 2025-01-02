// * Desafio 4

// 1 - Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
// 2 - Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
// 3 - Desenvolver um método da classe Conta que exibe suas informações.
// 4 - Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

// ! Ex. 1
BankAccount account = new BankAccount();
account.AccountNumber = 123456;
account.Owner = "John Doe";
account.Balance = 1000.00;
account.ShowAccount();
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 2
Thread.Sleep(2000);
BankAccount account2 = new BankAccount();
account2.AccountNumber = 654321;
account2.Owner = "Jane Doe";
account2.Balance = 2000.00;
Console.WriteLine($"Owner: {account2.Owner}");
Console.WriteLine($"Balance: {account2.Balance}");
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 3
    // public void ShowAccount(){
    //    Console.WriteLine("Account Number: " + AccountNumber);
    //    Console.WriteLine("Owner: " + Owner);
    //    Console.WriteLine("Balance: " + Balance);
    //}

// ! Ex. 4
Thread.Sleep(2000);
Car car = new Car();
car.Accelerate();
car.Brake();
car.Honk();
Thread.Sleep(2000);
Console.Clear();