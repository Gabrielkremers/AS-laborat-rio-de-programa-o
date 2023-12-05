public class Biblioteca
{
    private List<ItemBiblioteca> colecao;

    // Construtor que inicializa a coleção
    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à coleção
    public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // Método de sobrecarga para buscar um item por título
    public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        return colecao.First(item => item.Titulo == titulo);
    }

    // Método de sobrecarga para buscar um item por id
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return colecao.First(item => item.Id == id);
    }
}