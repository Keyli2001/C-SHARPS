using System;

public class Alumno:Persona
{
    
    public int Contra { get; set; }

    public Alumno(long numerocuenta, string nombre,int contra, string carrera )
    {
        NumeroCuenta = numerocuenta;
        Nombre = nombre;
        Contra = contra;
        Carrera = carrera;
    }


    
}