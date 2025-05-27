using EspacioCalculadora;

Calculadora Calc=new Calculadora();


/*Calc.Sumar(2);
Calc.Sumar(4);

Console.WriteLine(Calc.Resultado.ToString()); */
int opcion = 0;
do
{
    Console.WriteLine("Ingrese una ocpcion:");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("6- Resultado");
    Console.WriteLine("7- Salir");

    string texto = Console.ReadLine();
    opcion = int.Parse(texto);

    if (opcion > 7 || opcion < 0)
    {
        Console.WriteLine("Elija una de las opciones");
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Coloque el valor que desea sumar");
            string textoSuma = Console.ReadLine();
            int valor = int.Parse(textoSuma);
            Calc.Sumar(valor);
            break;
        case 2:
            Console.WriteLine("Coloque el valor que desea restar");
            string textoResta = Console.ReadLine();
            int valorResta = int.Parse(textoResta);
            Calc.Restar(valorResta);
            break;
        case 3:
            Console.WriteLine("Coloque el valor que desea multiplicar");
            string textoMult = Console.ReadLine();
            int valorMult = int.Parse(textoMult);
            Calc.Multiplicar(valorMult);
            break;
        case 4:
            Console.WriteLine("Coloque el valor que desea dividir");
            string textoDiv = Console.ReadLine();
            int valorDiv = int.Parse(textoDiv);
            Calc.Dividir(valorDiv);
            break;

        case 5:
            Console.WriteLine("Limpiando...");
            Calc.Limpiar();
            break;
        case 6:
            Console.WriteLine("Resultado: " + Calc.Resultado.ToString());
            Console.WriteLine("------------------------\n\n");
            break;
        case 7:
            Console.WriteLine("------------------------  Saliendo...  ------------------------\n\n");
            break;




    }


} while (opcion != 7);


