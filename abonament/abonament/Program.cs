using abonament.DataModels;

internal class Program
{
    private static void Main(string[] args)
    {
        AbonamentOffer abon = new AbonamentOffer(6, 12.5, 60);

        AbonamentOffer numero1 = new AbonamentOffer(2, 4, 30.6);
        AbonamentOffer numero2 = new AbonamentOffer(12,50,50);

        Console.WriteLine(abon.UltimateGetter());
        Console.WriteLine(numero1.UltimateGetter());
        Console.WriteLine(numero2.UltimateGetter());

        AbonamentsList lista = new AbonamentsList();
        lista.AddOffert(abon);
        lista.AddOffert(numero1);
        lista.AddOffert(numero1);


        Console.WriteLine();
        Console.WriteLine(lista.shortesttime().UltimateGetter());
        Console.WriteLine(lista.LowestPrice().UltimateGetter());
    }
}