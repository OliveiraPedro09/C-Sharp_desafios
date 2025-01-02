// * Desafio 2 

// A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

// Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

// Desafio - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

void Menu(){
    Console.WriteLine(@"
╭━━━╮╱╱╭╮╱╱╱╱╱╱╭╮╱╱╱╱╱╭╮
┃╭━╮┃╱╱┃┃╱╱╱╱╱╱┃┃╱╱╱╱╱┃┃
┃┃╱╰╋━━┫┃╭━━┳╮╭┫┃╭━━┳━╯┣━━┳━┳━━╮
┃┃╱╭┫╭╮┃┃┃╭━┫┃┃┃┃┃╭╮┃╭╮┃╭╮┃╭┫╭╮┃
┃╰━╯┃╭╮┃╰┫╰━┫╰╯┃╰┫╭╮┃╰╯┃╰╯┃┃┃╭╮┃
╰━━━┻╯╰┻━┻━━┻━━┻━┻╯╰┻━━┻━━┻╯╰╯╰╯");
    Console.WriteLine("\nQual Operação deseja realizar?");
    Console.WriteLine("\n1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    Console.Write("\nDigite a opção desejada: ");
    string option = Console.ReadLine()!;

    int intOption = int.Parse(option);

    switch(intOption){
        case 1:
            Adicao();
            break;
        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        case 5:
            Console.Write("Saindo...");
            Console.Clear();
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Console.Clear();
            return;
    }
};


void Adicao(){
    Console.Clear();
    Console.WriteLine(@"
╭━━━╮╱╭╮
┃╭━╮┃╱┃┃
┃┃╱┃┣━╯┣┳━━┳━━┳━━╮
┃╰━╯┃╭╮┣┫╭━┫╭╮┃╭╮┃
┃╭━╮┃╰╯┃┃╰━┫╭╮┃╰╯┃
╰╯╱╰┻━━┻┻━━┻╯╰┻━━╯");
    Console.Write("Digite o primeiro número: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o segundo número: ");
    double b = double.Parse(Console.ReadLine()!);

    double result = a + b;
    Console.WriteLine($"O resultado da adição é: {result}");
    Thread.Sleep(2000);
    Menu();
}

void Subtracao(){
    Console.Clear();
    Console.WriteLine(@"
╭━━━╮╱╱╭╮╱╭╮
┃╭━╮┃╱╱┃┃╭╯╰╮
┃╰━━┳╮╭┫╰┻╮╭╋━┳━━┳━━┳━━┳━━╮
╰━━╮┃┃┃┃╭╮┃┃┃╭┫╭╮┃╭━┫╭╮┃╭╮┃
┃╰━╯┃╰╯┃╰╯┃╰┫┃┃╭╮┃╰━┫╭╮┃╰╯┃
╰━━━┻━━┻━━┻━┻╯╰╯╰┻━━┻╯╰┻━━╯");
    Console.Write("Digite o primeiro número: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o segundo número: ");
    double b = double.Parse(Console.ReadLine()!);

    double result = a - b;
    Console.WriteLine($"O resultado da subtração é: {result}");
    Thread.Sleep(2000);
    Menu();
}

void Multiplicacao(){
    Console.Clear();
    Console.WriteLine(@"
╭━╮╭━╮╱╱╭╮╭╮╱╱╱╱╭╮
┃┃╰╯┃┃╱╱┃┣╯╰╮╱╱╱┃┃
┃╭╮╭╮┣╮╭┫┣╮╭╋┳━━┫┃╭┳━━┳━━┳━━┳━━┳━━╮
┃┃┃┃┃┃┃┃┃┃┃┃┣┫╭╮┃┃┣┫╭━┫╭╮┃╭━┫╭╮┃╭╮┃
┃┃┃┃┃┃╰╯┃╰┫╰┫┃╰╯┃╰┫┃╰━┫╭╮┃╰━┫╭╮┃╰╯┃
╰╯╰╯╰┻━━┻━┻━┻┫╭━┻━┻┻━━┻╯╰┻━━┻╯╰┻━━╯
╱╱╱╱╱╱╱╱╱╱╱╱╱┃┃
╱╱╱╱╱╱╱╱╱╱╱╱╱╰╯");
    Console.Write("Digite o primeiro número: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o segundo número: ");
    double b = double.Parse(Console.ReadLine()!);

    double result = a * b;
    Console.WriteLine($"O resultado da multiplicação é: {result}");
    Thread.Sleep(2000);
    Menu();
}

void Divisao(){
    Console.Clear();
    Console.WriteLine(@"
╭━━━╮
╰╮╭╮┃
╱┃┃┃┣┳╮╭┳┳━━┳━━┳━━╮
╱┃┃┃┣┫╰╯┣┫━━┫╭╮┃╭╮┃
╭╯╰╯┃┣╮╭┫┣━━┃╭╮┃╰╯┃
╰━━━┻╯╰╯╰┻━━┻╯╰┻━━╯");
    Console.Write("Digite o primeiro número: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o segundo número: ");
    double b = double.Parse(Console.ReadLine()!);

    double result = a / b;
    Console.WriteLine($"O resultado da divisão é: {result}");
    Thread.Sleep(2000);
    Menu();
}

Menu();
