public class Terreno
{
    //Atributos
    private double largura;
    private double comprimento;


    //Metodo Get e Set
    public double GetLargura()
    {
        return this.largura;
    }
    public void SetLargura(double largura)
    {
        this.largura = largura;
    }


    //Metodo Get e Set
    public double GetComprimento()
    {
        return this.comprimento;
    }
    public void SetComprimento(double comprimento)
    {
        this.comprimento = comprimento;
    }

    //Metodo construtor
    public Terreno(double largura, double comprimento)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }

    public double AreaTerreno()
    {
        double area = largura * comprimento;
        return area;
    }

    public double ValorEstimado(double metro)
    {
        return metro * AreaTerreno();
    }
}
