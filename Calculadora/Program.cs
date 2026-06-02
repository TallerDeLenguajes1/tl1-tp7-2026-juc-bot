using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora();

bool continuar = true;

int operar()
{
            int num;
            string numeroIngresado;
            numeroIngresado = Console.ReadLine();
            bool resultado = int.TryParse(numeroIngresado, out num);
            return num;
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
            miCalculadora.Sumar(operar());
            break;
        case "2":
            Console.WriteLine("Ingrese el numero a restar");
            miCalculadora.Restar(operar());
            break;
        case "3":
            Console.WriteLine("Ingrese el numero a multiplicar");
            miCalculadora.Multiplicar(operar());
            break;
        case "4":
            Console.WriteLine("Ingrese el numero a Dividir");
            miCalculadora.Dividir(operar());
            break;
        case "5":
            miCalculadora.Limpiar();
            break;
        case "0":
            continuar = false;
            break;
        default:
        Console.WriteLine("operacion invalida");
        break;
    }
}