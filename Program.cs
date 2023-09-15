using System;

interface ITributavel
{
    double CalcularValorTotal();
}

class Imovel : ITributavel
{
    public double Valor { get; private set; }
    public bool ENovo { get; private set; }

    public Imovel(double Valor, bool ENovo)
    {
        this.Valor = Valor;
        this.ENovo = ENovo;
    }

    public double CalcularValorTotal()
    {
        double taxaDeImpostos;
        if (ENovo)
        {
            taxaDeImpostos = 0.05;
        } 
        else 
        {
            taxaDeImpostos = 0.15;
        }

        double impostos = Valor * taxaDeImpostos;
        double valorTotal = Valor + impostos;

        return valorTotal;
    }
}

class program
{
    static void Main(string[] args)
    {
        Imovel imovelNovo = new Imovel(200000, true);
        Imovel imovelVelho = new Imovel(150000, false);

        Console.WriteLine("Imóvel Novo:");
        Console.WriteLine($"Valor Total (com impostos): {imovelNovo.CalcularValorTotal():c2}");

        Console.WriteLine("Imóvel Velho:");
        Console.WriteLine($"Valor Total (com impostos: {imovelNovo.CalcularValorTotal():c2})");
    }
}