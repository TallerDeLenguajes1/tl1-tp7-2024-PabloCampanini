namespace EspacioEmpleado;

public enum Cargo
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado 
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private Cargo cargo;

    //Declaracion de las propiedades
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }
    
    public string Apellido
    {
        get => apellido;
        set => apellido = value;
    }

    public DateTime FechaNacimiento
    {
        get => fechaNacimiento;
        set => fechaNacimiento = value;
    }

    public char EstadoCivil 
    { 
        get => estadoCivil; 
        set => estadoCivil = value; 
    }

    public DateTime FechaIngreso 
    { 
        get => fechaIngreso; 
        set => fechaIngreso = value; 
    }

    public double SueldoBasico 
    { 
        get => sueldoBasico; 
        set => sueldoBasico = value; 
    }

    public Cargo Cargo 
    { 
        get => cargo; 
        set => cargo = value; 
    }

    //Constructor
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargo cargo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaNacimiento = fechaNacimiento;
        this.EstadoCivil = estadoCivil;
        this.FechaIngreso = fechaIngreso;
        this.SueldoBasico = sueldoBasico;
        this.Cargo = cargo;
    }

    //Metodos
    public int CalcularAntiguedad()
    {
        DateTime fechaActual = DateTime.Now;

        int antiguedad = fechaActual.Year - FechaIngreso.Year;

        if (fechaActual.Month < FechaIngreso.Month || ((fechaActual.Month == FechaIngreso.Month) && (fechaActual.Day < FechaIngreso.Day)))
        {
            antiguedad--;
        }

        return antiguedad;
    }

    public int CalcularEdad()
    {
        DateTime fechaActual = DateTime.Now;

        int edad = fechaActual.Year - FechaNacimiento.Year;

        if (fechaActual.Month < FechaNacimiento.Month || ((fechaActual.Month == FechaNacimiento.Month) && (fechaActual.Day < FechaNacimiento.Day)))
        {
            edad--;
        }

        return edad;
    }

    public int FaltaJubilacion()
    {
        int aniosFaltantes = 65 - CalcularEdad();

        return aniosFaltantes;
    }

    public double CalcularSalario()
    {
        double Adicional = 0;

        int antiguedad = CalcularAntiguedad();

        if (antiguedad <= 20)
        {
            Adicional = SueldoBasico * (antiguedad * 0.01);
        }
        else
        {
            Adicional = SueldoBasico * 0.25;
        }

        if (Cargo == Cargo.Ingeniero || Cargo == Cargo.Especialista)
        {
            Adicional *= 1.50;
        }

        if (EstadoCivil == 'C' || EstadoCivil == 'c')
        {
            Adicional += 150000;
        }

        double Salario = SueldoBasico + Adicional;

        return Salario;
    }
}
