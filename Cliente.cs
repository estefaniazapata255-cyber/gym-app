public class Cliente : Persona // Esta heredado de la clase padre Persona 
{
    public string plan { get; set; }
    public string fechaIngreso { get; set; }
    public bool activo { get; set; }

    public Cliente // Constructor de cliente 1
    (
        string nombre,
        string documento,
        string correo,
        int edad,
        string plan,
        string fechaIngreso
    )
    :base(nombre, documento, correo, edad)
    {
        this.plan = plan;
        this.fechaIngreso = fechaIngreso;
        this.activo = true;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo(); // Ejecuta el MostrarInfo() de Persona
        Console.WriteLine("Plan: " + plan);
        Console.WriteLine("Fecha de Ingreso: " + fechaIngreso);
        Console.WriteLine("Estado: " + (activo ? "Activo" : "Inactivo"));
    }
    public bool TieneMembresia()
    {
        return activo;
    }
}