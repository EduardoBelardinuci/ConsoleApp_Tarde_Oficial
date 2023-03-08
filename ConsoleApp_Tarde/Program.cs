// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;

Produto p1 = new Produto(1, "Mouse Xing Ling", 10.90M);
Produto p2 = new Produto(2, "Teclado Multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

//Classe Cliente

Cliente c1 = new Cliente(1, "Eduardo", "16981023552");

Console.WriteLine(c1.getNome() + " " + c1.getTelefone());

c1.setNome("Joao");
c1.setTelefone("16981003461");

Console.WriteLine(c1.getNome() + " " + c1.getTelefone());

//Classe Endereco

Endereco e1 = new Endereco(1, "15906-044", "Rua Franciso", 93, "Centro", "Taquaritinga");

Console.WriteLine(e1.getId() + " " + e1.getCEP() + " " + e1.getCidade() + " " + e1.getBairro());

e1.setCidade("Araraquara");
e1.setBairro("Vila");

Console.WriteLine(e1.getCidade() + " " + e1.getBairro());


