namespace EspacioCalculadora;

public class Calculadora
{
    private double resultado;

    public double Resultado { get => resultado; }
 
    public void Sumar(double termino)
    {
        resultado = resultado + termino;

    }
    public void Restar(double termino)
    {
        resultado = resultado - termino;

    }
    public void Multiplicar(double termino)
    {
        resultado = resultado * termino;

    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            resultado = resultado / termino;

        }
        else
        {
            Console.WriteLine("No se puede dividir en 0");
        }

    }
    public void Limpiar()
    {
        Console.WriteLine("Limpiando...\n");
        resultado = 0;
    }

    
}