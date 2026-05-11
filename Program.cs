using System;
public class Program
{
    static void Main()
    {
       Empleado empleado1 = new Empleado( // Objeto empleado 1
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
        Console.WriteLine("==========================");
        empleado1.CalcularSueldo("Hola");

        Console.WriteLine("==========================");
        empleado1.CalcularSueldo(0.5);

        
        Cliente cliente1 = new Cliente( // Objeto cliente 1
         "Estefania Zapata", 
         "987654321", 
         "estefania@hotmail.com", 
         24, 
         "Premium", 
         "10/05/2026"
        );



        cliente1.MostrarInfo();
        Console.WriteLine("¿Tiene membresía?: " + cliente1.TieneMembresia());

        cliente1.activo = false; 
        cliente1.MostrarInfo(); 

        cliente1.fechaIngreso = "25/10/2006";
        cliente1.MostrarInfo();


    }
}