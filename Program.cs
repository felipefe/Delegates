// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace Delegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region  Exemplo1

            // Calcular media;
            // media = CalcularMedia;
            // Console.WriteLine(media(3, 5));

            // media = CalcularSoma;
            // Console.WriteLine(media(3, 5));

            static float Media(int v1, int v2)
            {
                return (v1 + v2) / 2;
            }

            static float Soma(int v1, int v2)
            {
                return v1 + v2;
            }

            var c = new Calculos
            {
                p1 = 5,
                p2 = 10
            };

            //Execucao
            // c.CalcularMedia += Media;
            // Console.WriteLine(c.EventHandler());
            // c.CalcularMedia += Soma;
            // Console.WriteLine(c.EventHandler());

            #endregion Exemplo1

            #region Exemplo2

            static void Impressora1(string texto)
            {
                Console.WriteLine("Impressora 1 recebe " + texto);
            }
            static void Impressora2(string texto)
            {
                Console.WriteLine("Impressora 2 recebe " + texto);
            }

            var print = new Imprimir
            {
                Texto = "Hello World!"
            };

            print.Printer += Impressora1;
            print.Printer += Impressora2;
            //Execucao
            // print.EventHandler();

            #endregion Exemplo2

            #region Exemplo3 Action Func Predicate

            var p1 = new Produto();
            p1.Notificar += Notify;
            p1.Add("Ventilador");
            p1.Add("Geladeira");

            //Action
            Action<Produto> action = new Action<Produto>(i => Console.WriteLine(i));
            p1.PrintItem(action);

            //Func 
            Func<Produto, bool> func = new Func<Produto, bool>(j => j.ID == 1);
            var item = p1.GetItemById(func);
            Console.WriteLine(item);

            //Predicate
            Predicate<Produto> predicate = new Predicate<Produto>(i => i.Nome == "JBL");
            Console.WriteLine(p1.ExistItem(predicate));

            static void Notify()
            {
                Console.WriteLine("Success! Produto criado!");
            }

            #endregion Exemplo3 Action Func Predicate
        }

        // public static float CalcularMedia(int v1, int v2)
        // {
        //     return (v1 + v2) / 2;
        // }

        // public static float CalcularSoma(int v1, int v2)
        // {
        //     return v1 + v2;
        // }
    }
}