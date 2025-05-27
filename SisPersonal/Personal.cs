namespace EspacioPersonal;

public class Personal
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estCivil;
    private DateTime fechaIng;
    private double sueldo;

    public enum cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Esoecialista,
        Investigador

    }



    public double Resultado { get => resultado; }
 
    public void CargarDatos(double termino)
    {
        resultado = resultado + termino;

    }


    public void antiguedad(DateTime fechaIng)
    {

        DateTime hoy = DateTime.Now;
        int años = hoy.Year - fechaIng.Year;
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