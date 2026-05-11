public class Persona 
{
    protected string nombre;
    protected string documento;
    protected string correo;
    private int edad;
    public int Edad // Es una propiedad
    {
        get {return edad;}
        set {
            if (value >= 0 && value <= 110){
                edad = value;
            }else{
                Console.WriteLine("Error.. La edad debe de ser positiva");
            }
        }
    }
    
    public Persona //Constructor 1
    (
        string nombre,
        string documento,
        string correo,
        int edad
    )
    
    {
        this.nombre = nombre;
        this.documento = documento;
        this.correo = correo;
        this.edad = edad;
    }
    
    public virtual void MostrarInfo()
    {   
        Console.WriteLine("=======================");
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("Documento: " + this.documento);
        Console.WriteLine("Correo:" + this.correo);
        Console.WriteLine("Edad:" + this.edad);
    }
}