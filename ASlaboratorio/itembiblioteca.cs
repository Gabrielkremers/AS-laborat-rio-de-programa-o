public abstract class ItemBiblioteca
{
    // Propriedades públicas
    public int Id { get; }
    public string Titulo { get; }

    // Propriedade protegida
    protected string DescricaoInterna { get; set; }

    // Construtor
    protected ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Descrição Padrão";
    }
}


