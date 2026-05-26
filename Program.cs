using EspacioCalculadora;

Console.WriteLine("Hello, World!");

Calculadora miCalculadora = new Calculadora();
miCalculadora.Limpiar();
miCalculadora.Sumar(5);
Console.WriteLine("Resultado: " + miCalculadora.Dato);
bool continuar = true;

void operar(int operacion)
{
    
}

while(continuar)
{
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Limpiar");
    Console.WriteLine("0- Salir");
    string opcion = Console.ReadLine();
    switch(opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el numero a sumar");
            int num;
            string numeroIngresado;
            numeroIngresado = Console.ReadLine();
            bool resultado = int.TryParse(numeroIngresado, out num);
            miCalculadora.Sumar(num);
            break;
        case "2":
            Console.WriteLine("Ingrese el numero a restar");
            break;
    }
}