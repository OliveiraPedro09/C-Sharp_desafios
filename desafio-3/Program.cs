// * Desafio 3 
// 1 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
// 2 - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
// 3 - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
// 4 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.


// ! Ex. 1
Dictionary<string, List<int>> aluno = new Dictionary<string, List<int>>();
aluno.Add("João", new List<int> { 10, 3, 6});
aluno.Add("Maria", new List<int> { 6, 10, 9});
aluno.Add("José", new List<int> { 2, 3, 10});

void MediaNotas(Dictionary<string, List<int>> aluno)
{
    foreach (var item in aluno)
    {
        double media = item.Value.Average();
        Console.WriteLine($"A média das notas do aluno {item.Key} é {media}");
    }
}

MediaNotas(aluno);
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 2
Thread.Sleep(2000);
Dictionary<string, int> produto = new Dictionary<string, int>();
produto.Add("Arroz", 10);
produto.Add("Feijao", 5);
produto.Add("Macarrão", 3);

void ProductStock(Dictionary<string, int> produto){
    foreach (string produtos in produto.Keys){
        Console.WriteLine($"Produto: {produtos}");
    }
    Console.Write("\nDigite o nome do produto: ");
    string nomeProduto = Console.ReadLine()!;
    if(produto.ContainsKey(nomeProduto)){
        foreach (var item in produto)
        {
            if(item.Key == nomeProduto){
                Console.WriteLine($"O produto {item.Key} tem {item.Value} unidades em estoque.");
            }
        }
    }
}

ProductStock(produto);
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 3
Thread.Sleep(2000);

Dictionary<string, string> quiz = new Dictionary<string, string>();
quiz.Add("Qual a capital do Brasil?", "Brasilia");
quiz.Add("Qual a capital da Argentina?", "Buenos Aires");
quiz.Add("Qual a capital do Chile?", "Santiago");
quiz.Add("Qual a capital da Alemanha?", "Berlim");
quiz.Add("Qual a capital da França?", "Paris");
quiz.Add("Qual a capital da Itália?", "Roma");
quiz.Add("Qual a capital do Japão?", "Toquio");
quiz.Add("Qual a capital da China?", "Pequim");
quiz.Add("Qual a capital da Rússia?", "Moscou");

void Quiz(Dictionary<string, string> quiz){
    foreach(var item in quiz){
        Console.WriteLine(item.Key);
        Console.Write("Resposta: ");
        string resposta = Console.ReadLine()!;
        if(resposta == item.Value){
            Console.WriteLine("Resposta correta!");
        } else {
            Console.WriteLine("Resposta incorreta!");
        }
    }
}
Quiz(quiz);
Thread.Sleep(2000);
Console.Clear();

// ! Ex. 4
Thread.Sleep(2000);

Dictionary<string, string> login = new Dictionary<string, string>();
login.Add("admin", "admin");

void Login(Dictionary<string, string> login){
    Console.Write("Digite o nome de usuário: ");
    string usuario = Console.ReadLine()!;
    Console.Write("Digite a senha: ");
    string senha = Console.ReadLine()!;
    if(login.ContainsKey(usuario) && login.ContainsValue(senha)){
        Console.WriteLine("Login efetuado com sucesso!");
    } else {
        Console.WriteLine("Usuário ou senha incorretos!");
    }
}

Login(login);
Thread.Sleep(2000);
Console.Clear();