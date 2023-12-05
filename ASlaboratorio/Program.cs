// Criando uma instância de Biblioteca
Biblioteca biblioteca = new Biblioteca();

// Criando uma instância de Livro
Livro livro1 = new Livro(1, "Caverna do Dragão", "João");
Livro livro2 = new Livro(2, "desesperados da faculdade", "Gabriel");

// Adicionando livros à biblioteca
biblioteca.AdicionarItem(livro1);
biblioteca.AdicionarItem(livro2);

// Demonstrando a busca de livros por título e ID
Livro livroEncontradoPorTitulo = (Livro)biblioteca.BuscarItemPorTitulo("Caverna do Dragão");
Livro livroEncontradoPorId = (Livro)biblioteca.BuscarItemPorId(2);

if (livroEncontradoPorTitulo != null)
{
    Console.WriteLine($"Livro encontrado por título: {livroEncontradoPorTitulo.Titulo}");
}

if (livroEncontradoPorId != null)
{
    Console.WriteLine($"Livro encontrado por ID: {livroEncontradoPorId.Titulo}");
}

// Exibindo a DescricaoInterna do livro encontrado por título
livroEncontradoPorTitulo?.ExibirDescricaoInterna();

// Removendo um livro da biblioteca
biblioteca.RemoverItem(livro1);

// Tentando buscar o livro removido por título (deve retornar null)
Livro livroRemovido = (Livro)biblioteca.BuscarItemPorTitulo("Caverna do Dragão");

if (livroRemovido == null)
{
    Console.WriteLine("Livro removido");
}
