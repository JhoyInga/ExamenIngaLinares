// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using static System.Runtime.InteropServices.JavaScript.JSType;

void MostrarMenu()
{
    int opcion;

    do
    {
        Console.WriteLine("Ingresa una de las siguientes opciones:");
        Console.WriteLine("1) Numero positivo, negativo o cero.");
        Console.WriteLine("2) Imprimir nombre dia de la semana.");
        Console.WriteLine("3) Sumar 100 primeros numeros naturales");
        Console.WriteLine("4) Imprimir todos los numeros desde 1 hasta el numero ingresado.");
        Console.WriteLine("5) Calcular area de un circulo.");
        Console.WriteLine("6) Mostrar elementos de un arreglo unidimensional.");
        Console.WriteLine("7) Mostrar de personas almacenadas en una lista.");
        Console.WriteLine("8) Salir");
        opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese un numero a evaluar:");
                ObtenerNumeroPositivoNegativo(Convert.ToDouble(Console.ReadLine()));
                break;

            case 2:
                Console.WriteLine("Ingrese un numero de dia de la semana:");
                DiasDeLaSemana(Convert.ToInt32(Console.ReadLine()));
                break;
            case 3:
                Console.WriteLine("Suma de 100 primeros numeros = " + SumaNumeroNaturales(100));
                break;
            case 4:
                Console.WriteLine("Ingrese numero.");
                ImprimirNumero(Convert.ToInt32(Console.ReadLine()));
                break;
            case 5:
                Console.WriteLine("Ingrese el radio del circulo: ");
                AreaCirculo(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("El area del circulo es = " + AreaCirculo(100));
                break;
            case 6:
                Console.WriteLine("Mostrar arreglo de edades.");
                EdadesArreglos();
                break;
            case 7:
                Console.WriteLine("Mostrar arreglo de nombres.");
                NombresArreglos();
                break;

            default:
                break;
        }

        Console.WriteLine("==============================");
        Console.WriteLine("==============================");

    } while (opcion != 8);

}

double ObtenerNumeroPositivoNegativo(double numIngresado)
{
    double numero = numIngresado;

    if (numero > 0)
    {
        Console.WriteLine("El numero ingresado es positivo.");
    }
    else if (numero < 0)
    {
        Console.WriteLine("El numero ingresado es negativo.");
    }
    else if (numero == 0)
    {
        Console.WriteLine("El numero ingresado es cero.");
    }
    return numero;
}

void DiasDeLaSemana(int valorDia)
{
    int numero = valorDia;
    switch (numero)
    {
        case 1:
            Console.WriteLine("Dia elegido: Lunes");
            break;
        case 2:
            Console.WriteLine("Dia elegido: Martes");
            break;
        case 3:
            Console.WriteLine("Dia elegido: Miercoles");
            break;
        case 4:
            Console.WriteLine("Dia elegido: Jueves");
            break;
        case 5:
            Console.WriteLine("Dia elegido: Viernes");
            break;
        case 6:
            Console.WriteLine("Dia elegido: Sabado");
            break;
        case 7:
            Console.WriteLine("Dia elegido: Domingo");
            break;
        default:
            Console.WriteLine("Debe elegir un número de día valido entre 1 y 7.");
            break;
    }
}

int SumaNumeroNaturales(int valor)
{
    int numero = 1;

    for (int i = 0; i <= valor; i++)
    {
        numero = (i * (i + 1)) / 2;

    }

    return numero;
}

void ImprimirNumero(int valor)
{
    int numero = 1;

    for (int i = 0; i <= valor-1; i++)
    {
        numero = i + 1;
        Console.WriteLine("Numero: " + numero);
    }
}

double AreaCirculo(int radio)
{
    double area = 0;
    area = Math.PI * Math.Pow(radio, 2);

    return area;
}

void EdadesArreglos()
{
    int[] Edades = new int[10];
    Edades[0] = 10;
    Edades[1] = 20;
    Edades[2] = 35;
    Edades[3] = 40;
    Edades[4] = 60;
    Edades[5] = 3;
    Edades[6] = 8;
    Edades[7] = 12;
    Edades[8] = 28;
    Edades[9] = 52;

    for (int i = 0; i < Edades.Length; i++)
    {
        Console.WriteLine(Edades[i]);
    }
}

void NombresArreglos()
{
    string[] Nombre = new string[8];
    Nombre[0] = "Jorge";
    Nombre[1] = "Jose";
    Nombre[2] = "Ana";
    Nombre[3] = "Paula";
    Nombre[4] = "Karen";
    Nombre[5] = "Miguel";
    Nombre[6] = "Oscar";
    Nombre[7] = "Kevin";


    for (int i = 0; i < Nombre.Length; i++)
    {
        Console.WriteLine(Nombre[i]);
    }
}

MostrarMenu();