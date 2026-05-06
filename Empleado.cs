public class Empleado : Persona // Esta heredado de la clase padre Persona 
{
    private double sueldo;
    public string cargo;
    public double Sueldo
    {
        get {return sueldo;}
        set{
            if(value >= 0)
            {
                sueldo = value;
            }else{
                Console.WriteLine("Error... El sueldo debe de ser positivo");
            }
        }
    }

    public Empleado // Constructor de empleado 
    (
        string nombre,
        string documento,
        string correo,
        int edad,
        double sueldo,
        string cargo
    )
    :base(nombre, documento, correo, edad) // Le decimos que atributos hereda de la clase persona
    {
        this.sueldo = sueldo;
        this.cargo = cargo;
    }
}