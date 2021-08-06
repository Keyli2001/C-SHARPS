using System;

public class ListadoMatricula
{
    public Departamentos Departamento { get; set; }
    public int Num { get; set; }
    public Asignaturas Asignaturas { get; set; }
    public Secciones Secciones { get; set; }
    public string Horarios { get; set; }
    public int Cupos { get; set; }
    public string Profesor { get; set; }

    //public ListadoMatricula(int num, Asignaturas asignat, Secciones seccion,string horarios, int cupos, string profesor)
    public ListadoMatricula(Asignaturas asignaturas, Secciones seccion)
    {
        
        //Num = num;
        Secciones = seccion;
        Horarios = seccion.Horario;
        Cupos = seccion.Cupos;
        Profesor = seccion.Profesor;
        
        //Clase = Asignat.Clase;
        //Num = num;
        //horarios = secci.Horario;
        //Cupos = secci.Cupos;
        //Profe = secci.Profesor;
    }

}