class BankAccount(){
    public int AccountNumber { get; set; }
    public string Owner { get; set; } = string.Empty;
    public double Balance { get; set; }
    private string password { get; } = string.Empty;


    public void ShowAccount(){
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Owner: " + Owner);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Car(){
    public string Manufacturer { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    private int _year;
    public int Year{
        get { return _year; }
        set {
            if ( value >= 1960 && value <= 2023){
                _year = value;
            } else {
                Console.WriteLine("Year must be between 1960 and 2023");
            }
        }
    }
    public string DescriptionDetail => $" Fabricante :  {Manufacturer}\n Modelo : {Model}\n Ano : {Year}\n";
}

class Product(){
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    private double _price;
    public double Price { 
        get{
        return _price;
        }
        set {
            if (value < 0){
                Console.WriteLine("Price must be greater than 0");
            } else {
                _price = value;
            }
        }
    }
    private int _stock;
    public int Stock { 
        get {
            return _stock;
        } 
        set {
            if (value < 0){
                Console.WriteLine("Stock must be greater than 0");
            } else {
                _stock = value;
            }
        }
    }
    public void ShowProduct(){
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock: " + Stock);
    }
}