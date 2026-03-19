using System;
public class Departamento
{
    public string Nombre {get; set;}
    public void MostrarProfesor (Profesor p)
    {
        Console.WriteLine("Profesor: "+p.Nombre);
        Console.WriteLine("Departamento: "+Nombre);
    }
}
public class Profesor
{
    public string Nombre {get; set;}
}
public class Program
{
    static void Main()
    {
        Profesor profe=new Profesor();
        profe.Nombre="Vera";
        
        Departamento ingenieria=new Departamento();
        ingenieria.Nombre="Programacion Orientada a Objetos";
        
        ingenieria.MostrarProfesor(profe);
    }
}
