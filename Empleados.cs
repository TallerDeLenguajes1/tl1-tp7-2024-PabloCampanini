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
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    //Metodos
    public int CalculadoraAntiguedad()
    {
        DateTime fechaActual = DateTime.Now;

        int antiguedad = fechaActual.Year - fechaIngreso.Year;

        if (fechaActual.Month < fechaIngreso.Month || ((fechaActual.Month == fechaIngreso.Month) && (fechaActual.Day < fechaIngreso.Day)))
        {
            antiguedad--;
        }

        return antiguedad;
    }

    public int CalculadoraEdad()
    {
        DateTime fechaActual = DateTime.Now;

        int edad = fechaActual.Year - fechaNacimiento.Year;

        if (fechaActual.Month < fechaNacimiento.Month || ((fechaActual.Month == fechaNacimiento.Month) && (fechaActual.Day < fechaNacimiento.Day)))
        {
            edad--;
        }

        return edad;
    }

    public int FaltaJubilacion()
    {
        int aniosFaltantes = 65 - CalculadoraEdad();

        return aniosFaltantes;
    }

    public double CalculadoraSalario()
    {
        double Adicional = 0;

        int antiguedad = CalculadoraAntiguedad();

        if (antiguedad <= 20)
        {
            Adicional = SueldoBasico * (antiguedad * 0.01);
        }
        else
        {
            Adicional = sueldoBasico * 0.25;
        }

        if (cargo == Cargo.Ingeniero || cargo == Cargo.Especialista)
        {
            Adicional *= 1.50;
        }

        if (estadoCivil == 'C' || estadoCivil == 'c')
        {
            Adicional += 150000;
        }

        double Salario = sueldoBasico + Adicional;

        return Salario;
    }
}