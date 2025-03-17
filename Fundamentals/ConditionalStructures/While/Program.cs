namespace While{
    class Program{
        static void Main(string[] args){
            Console.Write("Digite a hora: ");
            int hora = int.Parse(Console.ReadLine());
            while(hora < 12){
                Console.WriteLine("Bom dia!: "+ hora+ "h");
                hora++;
            }
        }
    }
}