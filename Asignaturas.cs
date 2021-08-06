using System;

public class Asignaturas
{
    public string Clase { get; set; }
    public string Codigo_Clase { get; set; } 

    public Asignaturas(string codigo_clase, string clase)
    {
        Codigo_Clase = codigo_clase;
        Clase = clase;
    }
}