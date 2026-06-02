public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private DateTime fechaIngresoEmpresa;
    private double sueldo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngresoEmpresa { get => fechaIngresoEmpresa; set => fechaIngresoEmpresa = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }

    enum Cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5,
    }

    public int CalcularAntiguedad()
    {
        return DateTime.Now.Year - FechaIngresoEmpresa.Year;
    }
    public int CalcularAniosEmpleado()
    {
        return DateTime.Now.Year - fechaDeNacimiento.Year;
    }
    public int CalcularAniosJubilacion()
    {
        int edadEmpleado = DateTime.Now.Year - fechaDeNacimiento.Year;
        if (edadEmpleado <= 65)
        {
            return 65 - edadEmpleado;
        } else
        {
            return -1;
        }
    }
}