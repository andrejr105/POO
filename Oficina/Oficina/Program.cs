using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Models.Carro corcel = new Models.Carro("Chevrolet", "2");
        corcel.LigarDesligar();
        
        for(int i = 0; i < 10; i++)
        {
            corcel.Acelerar(15);
            corcel.Frear(9);
            corcel.Abastecer(1);
        }

        corcel.Exibir();

    }
}