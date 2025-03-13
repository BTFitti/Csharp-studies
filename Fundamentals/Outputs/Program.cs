using System.Globalization;
namespace Outputs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Essa linha define a variável CI que representa "cultura neutra". 
            //Isso significa que ela não segue as regras de formatação de números de nenhum país ou região específica.
            CultureInfo CI = CultureInfo.InvariantCulture;
            double x;
            x = 2.3456;
            Console.WriteLine(x.ToString("F2", CI));//Com quebra de linha
            Console.Write(x.ToString("F2", CI));//Sem quebra de linha
            //-------------------------------------------------------------
            int z,h;
            z = 5;
            h = 6;
            Console.WriteLine($"{z} x {h} = {z*h}");
            //É possível fazer o calculo dentro do WriteLine, sem precisar declarar a variavel.
            //No exemplo acima eu passo as variáveis dentro do próprio write line e faço a operação matemática também dentro!
        }
    }
}