namespace lista.Models;

public class Lista
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public DateTime DataAtualizacao { get; set; }
    public bool Ativo { get; set; }

    public Lista()
    {
        DataAtualizacao = DateTime.Now;
        Ativo = true;
    }
}