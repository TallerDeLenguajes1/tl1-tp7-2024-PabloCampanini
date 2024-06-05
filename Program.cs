// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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
        Console.WriteLine("\nOperaciones:\n\t1. Suma\n\t2. Resta\n\t3. Multiplicacion\n\t4. Division\n\n\n\t5. Salir");

        Console.WriteLine("\n\nIngrese el numero de la operacion que quiere realizar");

        string cadena = Console.ReadLine();

        seguir = OperacionElegida(cadena, seguir);
    }
}

int OperacionElegida(string cadena, int seguir)
{
    if (int.TryParse(cadena, out int operacion))
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
                    seguir = 0;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("\n\t\t*----- Ingrese un dato valido -----*");
    }

    return seguir;
}
