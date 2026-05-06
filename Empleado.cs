public class Empleado : Persona // Esta heredado de la clase padre Persona 
{
    private double sueldo;
    public string cargo = "";
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

    public Empleado // Constructor de empleado 2
    (
        string nombre,
        string documento,
        double sueldo
    )
    :base(nombre, documento) // Le decimos que atributos hereda de la clase persona
    {
        this.sueldo = sueldo;
    }

    public override void MostrarInfo() 
    {
        base.MostrarInfo(); // ejecuta el MostrarInfo() de Persona
        Console.WriteLine("Cargo: " + Cargo); //agrega lo propio de Empleado
        Console.WriteLine("Sueldo: $" + Sueldo.ToString("N0"));
    }

    public void CalcularSueldo(string tipo){ // Polimorfismo con sobre escritura de metodos 
        Console.WriteLine(this.sueldo);
    }

    public void CalcularSueldo(double descuento){
        Console.WriteLine(this.sueldo * descuento);
    }


}