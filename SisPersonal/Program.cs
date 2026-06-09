using EmpleadoEmpresa;

Empleado[] empleados = new Empleado[3];

for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();
    empleados[i].Nombre = Console.ReadLine();
    empleados[i].Apellido = Console.ReadLine();
    
}