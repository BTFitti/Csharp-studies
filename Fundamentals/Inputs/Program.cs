using System.Globalization;
//para se ler dados em C# usa-se o Console.ReadLine();
namespace Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo de leitura de uma string pelo console.
            string texto = Console.ReadLine();
            Console.WriteLine("O texto digitado foi: " + texto);

            //para ler numeros por exemplo o código muda um pouco, adiciona-se o .Parse
            //aqui eu converto o texto para int
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero digitado foi: " + n1);

            //aqui eu converto o texto para double
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("O numero digitado foi: " + n2.ToString("F2", CultureInfo.InvariantCulture));


            //aqui eu converto o texto para caractere
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("O caracter digitado foi: " + ch);

        }
    }
}