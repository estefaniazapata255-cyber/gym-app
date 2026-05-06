using System;
public class Program
{
    static void Main()
    {
       Empleado empleado1 = new Empleado(
        "Miguel Gutierrez",
        "1234567896",
        "miguel@gmail.com",
        22,
        1000.0,
        "Jefe de personal"
       );

        //    Console.WriteLine(empleado1.Sueldo);
        //    empleado1.Sueldo = 1200.20;
        //    Console.WriteLine(empleado1.Sueldo);
    empleado1.MostrarInfo();
    Console.WriteLine(==========================);
    empleado1.CalcularSueldo("Hola");

    Console.WriteLine(==========================);
    empleado1.CalcularSueldo("0.5");
    }
}