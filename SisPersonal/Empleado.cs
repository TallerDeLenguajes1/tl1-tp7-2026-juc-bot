public class Empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime FechaDeNacimiento;
    private char EstadoCivil;
    private DateTime FechaIngresoEmpresa;
    private double Sueldo;

    public string nombre { get => Nombre; set => Nombre = value; }
    public string apellido { get => Apellido; set => Apellido = value; }
    public DateTime fechaNacimiento { get => FechaDeNacimiento; set => FechaDeNacimiento = value; }
    public char estadoCivil { get => EstadoCivil; set => EstadoCivil = value; }
    public DateTime fechaIngresoEmpresa { get => FechaIngresoEmpresa; set => FechaIngresoEmpresa = value; }
    public double sueldo { get => Sueldo; set => Sueldo = value; }

    enum cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5,
    }

    public int CalcularAntiguedad()
    {
        return DateTime.Now.Year - fechaIngresoEmpresa.Year;
    }
    public int CalcularAniosEmpleado()
    {
        return DateTime.Now.Year - fechaNacimiento.Year;
    }
    public int CalcularAniosJubilacion()
    {
        int edadEmpleado = DateTime.Now.Year - fechaNacimiento.Year;
        if (edadEmpleado <= 65)
        {
            return 65 - edadEmpleado;
        } else
        {
            return -1;
        }
    }
}