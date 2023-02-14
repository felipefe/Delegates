namespace Delegate
{

    public delegate void Notificacao();

    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos = new List<Produto>();
        public event Notificacao Notificar;

        public void Add(string produto_nome)
        {
            var produto = new Produto();
            produto.ID += Produtos.Count;
            produto.Nome = produto_nome;
            Produtos.Add(produto);
            EventHandler();
        }

        public override string ToString()
        {
            return string.Format("Produto {0} - {1}", this.ID, this.Nome);
        }

        public void EventHandler()
        {
            Notificar();
        }

        //Action
        public void PrintItem(Action<Produto> action)
        {
            Produtos.ForEach(action);
        }

        //Func
        public Produto GetItemById(Func<Produto, bool> func)
        {
            return Produtos.FirstOrDefault(func);
        }

        //Predicate
        public bool ExistItem(Predicate<Produto> predicate)
        {
            return Produtos.Exists(predicate);
        }

    }
}