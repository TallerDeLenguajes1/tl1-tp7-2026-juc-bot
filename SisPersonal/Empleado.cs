namespace EmpleadoEmpresa;
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private DateTime fechaIngresoEmpresa;
    private double sueldo;
    private Cargos cargo;
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngresoEmpresa { get => fechaIngresoEmpresa; set => fechaIngresoEmpresa = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }



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
        }
        else
        {
            return -1;
        }
    }
    public double Adicional()
    {
        double adicional = 0;
        double Salario;
                if (CalcularAntiguedad() <= 20)
                {
                    adicional = Sueldo *  (CalcularAntiguedad() * 0.01);
                }
                else
                {
                    adicional = Sueldo * 0.25;
                }

                if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
                {
                    adicional *= 1.50;
                }
                
                if (EstadoCivil == 'C' || EstadoCivil == 'c')
                {
                    adicional += 150000;
                }
            Salario = sueldo + adicional;
        return Salario;
    }
}

public enum Cargos
{
    Auxiliar = 1,
    Administrativo = 2,
    Ingeniero = 3,
    Especialista = 4,
    Investigador = 5,
}