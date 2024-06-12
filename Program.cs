// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




// *----- Ejercicio 1 -----*


/*
using EspacioCalculadora;

Calculadora calc = new Calculadora();

Console.WriteLine("\n\n\t\t*----- Calculadora -----*");

Console.WriteLine("Ingrese un numero base: ");

string oracion = Console.ReadLine();

if (double.TryParse(oracion, out double numBase))
{
    calc.Sumar(numBase);

    int seguir = 1;

    while (seguir == 1)
    {
        Console.WriteLine("\nOperaciones:\n\t1. Suma\n\t2. Resta\n\t3. Multiplicacion\n\t4. Division\n\t5. Limpiar (Reinicia el numerro base en 0)\n\n\n\t6. Salir");

        Console.WriteLine("\n\nIngrese el numero de la operacion que quiere realizar");

        string cadena = Console.ReadLine();

        seguir = OperacionElegida(cadena, seguir);
    }
}

int OperacionElegida(string cadena, int seguir)
{
    if (int.TryParse(cadena, out int operacion))
    {
        if (operacion == 6)
        {
            seguir = 0;
        }
        else
        {
            Console.WriteLine("Ingrese un numero: ");

            string oracion2 = Console.ReadLine();

            if (double.TryParse(oracion2, out double numero))
            {
                switch (operacion)
                {
                    case 1:
                        calc.Sumar(numero);
                        Console.WriteLine($"\n\t\t*----- El resultado de la suma es = {calc.Resultado} -----*\n");
                        seguir = 1;
                        break;
                    case 2:
                        calc.Restar(numero);
                        Console.WriteLine($"\n\t\t*----- El resultado de la resta es = {calc.Resultado} -----*\n");
                        seguir = 1;
                        break;
                    case 3:
                        calc.Multiplicar(numero);
                        Console.WriteLine($"\n\t\t*----- El resultado del producto es = {calc.Resultado} -----*\n");
                        seguir = 1;
                        break;
                    case 4:
                        if (numero != 0)
                        {
                            calc.Dividir(numero);
                            Console.WriteLine($"\n\t\t*----- El resultado de la division es = {calc.Resultado} -----*\n");
                            seguir = 1;
                        }
                        else
                        {
                            Console.WriteLine("El 2do numero debe ser distinto de 0 para la division");
                            seguir = 1;
                        }
                        break;
                    case 5:
                        calc.Limpiar();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("\n\t\t*----- Ingrese un dato valido -----*");
    }

    return seguir;
}
*/




// *----- Ejercicio 2 -----*



using EspacioEmpleado;

Empleado empleado = new Empleado("German", "Parrado", new DateTime(1985, 8, 20), 'C', new DateTime(2010, 3, 1), 700000, Cargo.Ingeniero);

Empleado empleado1 = new Empleado("Facundo", "Fernandez", new DateTime(2000, 6, 10), 's', new DateTime(2023, 8, 6), 500000, Cargo.Auxiliar);

Empleado empleado2 = new Empleado("Jazmin", "Garcia", new DateTime(1970, 10, 25), 'c', new DateTime(1998, 6, 1), 800000, Cargo.Especialista);

double PagarTotalSalarios = empleado.CalcularSalario() + empleado1.CalcularSalario() + empleado2.CalcularSalario();

Console.WriteLine($"\n\n\t\t*----- Se necesitan ${PagarTotalSalarios} para pagar los salarios -----*");

Empleado ProximoJubilar = empleado;

if (empleado1.FaltaJubilacion() < ProximoJubilar.FaltaJubilacion())
{
    ProximoJubilar = empleado1;
}

if (empleado2.FaltaJubilacion() < ProximoJubilar.FaltaJubilacion())
{
    ProximoJubilar = empleado2;
}

InformacionDelEmpleado(empleado);
InformacionDelEmpleado(empleado1);
InformacionDelEmpleado(empleado2);

Console.WriteLine("\n\nEl empleado que esta proximo a jubilarse es:");
Console.WriteLine($"\n\t\t*----- {ProximoJubilar.Apellido}, {ProximoJubilar.Nombre} -----*\n\n");

static void InformacionDelEmpleado(Empleado empleado)
{
    Console.WriteLine($"\nEmpleado: {empleado.Apellido}, {empleado.Nombre}");
    Console.WriteLine($"\n\tEdad: {empleado.CalcularEdad()}\n\tAntiguedad: {empleado.CalcularAntiguedad()}");
    Console.WriteLine($"\tFaltan {empleado.FaltaJubilacion()} anios para jubilarse");
    Console.WriteLine($"\tSalario = ${empleado.CalcularSalario()}");
}