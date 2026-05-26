using System.Data;

namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;
    public double Dato {get => dato;}
    public void Sumar(double termino)
    {
        dato = dato + termino;
    }
    public void Restar(double termino)
    {
        dato = dato - termino;
    }
    public void Multiplicar(double termino)
    {
        dato = dato * termino;
    }
    public void Dividir(double termino)
    {
        dato = dato / termino;
    }
    public void Limpiar()
    {
        dato = 0;
    }
}