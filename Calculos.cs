namespace Delegate
{
    public delegate float Calcular(int v1, int v2);
    public delegate void Print(string text);

    public class Calculos
    {
        public int p1 { get; set; }
        public int p2 { get; set; }
        public event Calcular CalcularMedia;

        public float EventHandler()
        {
            return CalcularMedia(this.p1, this.p2);
        }
    }


    public class Imprimir
    {
        public event Print Printer;
        public string Texto {get; set;}

        public void EventHandler()
        {
            Printer(this.Texto);
        }
    }
}