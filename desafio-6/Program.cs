// * Desafio 6

// 1 - Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
// 2 - Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
// 3 - Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
// 4 - Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
// 5 - Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.


// ! Ex. 1

Titular titular =  new Titular("João", "123.456.789-00", "Rua 1, nº 1");
Conta conta = new Conta(titular, "1234", "567890", 5000.00m, 2000.00m);
Console.WriteLine(conta.ObterInformacoes());

// ! Ex. 2

// ! Ex. 3

// ! Ex. 4

// ! Ex. 5