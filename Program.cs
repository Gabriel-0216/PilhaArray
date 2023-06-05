namespace PilhaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando uma pilha com tamanho máximo de 10 elementos");
            var pilha = new Pilha(10);
            Console.WriteLine($"Pilha está vazia? {pilha.EstaVazia()}");
            Console.WriteLine($"Elemento no topo: {pilha.Topo()}");
            Console.WriteLine("Empilhando o elemento 5");
            pilha.Push(5);
            Console.WriteLine($"Elemento no topo: {pilha.Topo()}");
            Console.WriteLine("Empilhando o elemento 7");
            pilha.Push(7);
            Console.WriteLine($"Elemento no topo: {pilha.Topo()}");
            Console.WriteLine("removendo elemento");
            pilha.Pop();
            Console.WriteLine($"Elemento no topo: {pilha.Topo()}");
            Console.WriteLine("removendo elemento");
            pilha.Pop();
            Console.WriteLine($"Elemento no topo: {pilha.Topo()}");
        }
    }
    public class Pilha
    {
        int tamanho;
        int topo = -1;
        int[] pilha;

        public Pilha(int tamanhoMaximo)
        {
            tamanho = tamanhoMaximo;
            pilha = new int[tamanho];
        }
        public bool Push(int elemento)
        {
            if (topo >= tamanho) return false; //overflow
            pilha[++topo] = elemento;
            return true;
        }
        public void Pop()
        {
            if (topo < 0) return; //overflow
            var _ = pilha[topo--];
            return;
        }
        public int Topo()
        {
            if (topo < 0) return -1; //overflow
            return pilha[topo];
        }
        public bool EstaVazia() => topo < 0;
    }
}