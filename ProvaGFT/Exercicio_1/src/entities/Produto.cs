namespace Exercicio_1.src.entities
{
   public abstract class Produto
    {
        public string Name;
        public double Preco;
        public int Quantidade;

        public Produto(string Name, double Preco, int Quantidade)
        {
            this.Name = Name;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        } 
    }
}