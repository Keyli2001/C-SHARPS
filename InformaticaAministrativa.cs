using System;

public class Informatica:DetallesDeClases
{
    public string Codigo { get; set; }

    public Informatica(string codigo, string clase, int seccion, string horario, int cupos, string profesor)
    {
        Codigo = codigo;
        Clase = clase;
        Seccion = seccion;
        Horario = horario;
        Cupos = cupos;
        Profesor = profesor;
    }
    
}