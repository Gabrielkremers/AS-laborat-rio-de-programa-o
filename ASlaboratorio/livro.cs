public class Livro : ItemBiblioteca
{
    // Propriedade adicional
    public string Autor { get; }

    // Construtor que chama o construtor da classe base (ItemBiblioteca) e inicializa a propriedade Autor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
        // Inicializa a DescricaoInterna específica para a classe Livro
        DescricaoInterna = $"Livro escrito por {Autor}.";
    }

    // Método para exibir a DescricaoInterna
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna: {DescricaoInterna}");
    }
}