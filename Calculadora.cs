namespace EspacioCalculadora;

class Calculadora
{
    //Campos
    private double dato;

    //Metodos
    public void Sumar (double termino)
    {
        dato = dato + termino;
    }

    public void Restar (double termino)
    {
        dato = dato - termino;
    }

    public void Multiplicar (double termino)
    {
        dato = dato * termino;
    }

    public void Dividir (double termino)
    {
        if (termino != 0)
        {
            dato = dato / termino;
        }
        else
        {
            Console.WriteLine("Error division por 0");
        }
    }

    public void Limpiar ()
    {
        dato = 0;
    }

    //Propiedad
    public double Resultado{
        get => dato;
    }
}