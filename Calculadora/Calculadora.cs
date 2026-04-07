namespace ci_demo;
using System;
// Clase Calculadora completa con todas las operaciones básicas
public class Calculadora
{
    public int Sumar(int a, int b) => a + b;

    public int Restar(int a, int b) => a - b;

    public int Multiplicar(int a, int b) => a * b;

    public int Dividir(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}