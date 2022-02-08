namespace Exercicio_1.src.entities
{
    public class Livro : Produto
    {
        public string Name;
        public double Preco;
        public int Quantidade;
        public string Tema;
        public string Autor;

        public Livro (string Name, double Preco, int Quantidade)
        {
            this.Name = Name;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        
        
        
    }
}