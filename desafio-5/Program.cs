// * Desafio 5

// 1 - Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
// 2 - Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
// 3 - Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
// 4 - Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.

// ! Ex. 1

// class BankAccount(){
//     public int AccountNumber { get; set; }
//     public string Owner { get; set; } = string.Empty;
//     public double Balance { get; set; }
//     private string password { get } = string.Empty;


//     public void ShowAccount(){
//         Console.WriteLine("Account Number: " + AccountNumber);
//         Console.WriteLine("Owner: " + Owner);
//         Console.WriteLine("Balance: " + Balance);
//     }
// }

BankAccount account = new BankAccount();
account.AccountNumber = 123456;
account.Owner = "John Doe";
account.Balance = 1000.00;
account.ShowAccount();
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 2
Thread.Sleep(2000);
// public string Description { get; set; } = string.Empty;

    
// public string DescriptionDetail{
//     get{
//         return Manufacturer + " " + Model + " " + Year;
//     }
// }

Car carro1 = new Car();
carro1.Manufacturer = "Fusca";
carro1.Model = "Azul";
carro1.Year = 1975;
Console.WriteLine(carro1.DescriptionDetail);

Car carro2 = new Car();
carro2.Manufacturer = "Civic";
carro2.Model = "Preto";
carro2.Year = 2050;
Console.WriteLine(carro2.DescriptionDetail);
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 3
Thread.Sleep(2000);
// public int Year{
//     get { return _year; }
//     set {
//         if ( value >= 1960 && value <= 2023){
//             _year = value;
//         } else {
//             Console.WriteLine("Year must be between 1960 and 2023");
//         }
//     }
// }

Car carro3 = new Car();
carro3.Manufacturer = "Fusca";
carro3.Model = "Azul";
carro3.Year = 1975;
Console.WriteLine(carro3.DescriptionDetail);

Car carro4 = new Car();
carro4.Manufacturer = "Civic";
carro4.Model = "Preto";
carro4.Year = 2050;
Console.WriteLine(carro4.DescriptionDetail);
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 4
Thread.Sleep(2000);
Product product = new Product();
product.Name = "Smartphone";
product.Brand = "Samsung";
product.Price = 1500.00;
product.Stock = 10;
product.ShowProduct();
Thread.Sleep(2000);
Console.Clear();