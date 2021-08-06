using System;
using System.Collections.Generic;

public class VerAsignaturas
{

    public List<Informatica> ListadeIntroduccion { get; set; }
    public List<Informatica> ListadeTaller { get; set; }
    public List<Informatica> ListadeMetodologia { get; set; }         

    public VerAsignaturas()
    {
        ListadeIntroduccion = new List<Informatica>();
        Informatica A1 = new Informatica("01)", "Introduccion a Informatica", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A1);
        Informatica A2 = new Informatica("02)", "Introduccion a Informatica", 0710, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A2);
        Informatica A3 = new Informatica("03)", "Introduccion a Informatica", 0800, "LuMaMiJue",30,"Bily Fernandez");
        ListadeIntroduccion.Add(A3);

        ListadeTaller = new List<Informatica>();
        Informatica T1 = new Informatica("11)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T1);
        Informatica T2 = new Informatica("12)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T2);
        Informatica T3 = new Informatica("13)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeTaller.Add(T3);

        ListadeMetodologia = new List<Informatica>();
        Informatica M1 = new Informatica("21)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeMetodologia.Add(M1);
        Informatica M2 = new Informatica("22)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeMetodologia.Add(M2);
        Informatica M3 = new Informatica("23)", "Taller de Hardware 1", 0700, "LuMaMiJue",30,"Bily Fernandez");
        ListadeMetodologia.Add(M3);

    }
public void VerClasesDisponibles()
{
    
}
    public void Intro()
    {
        Console.Clear();
        Console.WriteLine("Asignaturas y Secciones");
        Console.WriteLine("");
        Console.WriteLine("             Asignatura           |Secc | Horarios  | Cupos | Profesor");
        Console.WriteLine("Introduccion a Informatica --------------------------------------------------------------------");
        foreach (var In in ListadeIntroduccion)
        {
            Console.WriteLine(In.Codigo + " | " + In.Clase + "  | " + In.Seccion + " | " + In.Horario + " | " + In.Cupos + "    | " + In.Profesor);
        } 
    
    }

    public void Taller()
    {
        foreach (var Ta in ListadeTaller)
        {
            Console.WriteLine(Ta.Codigo + " | " + Ta.Clase + "        | " + Ta.Seccion + " | " + Ta.Horario + " | " + Ta.Cupos + "    | " + Ta.Profesor);
        }
       
    }

    public void Metodo()
    {
        foreach (var Me in ListadeMetodologia)
        {
            Console.WriteLine(Me.Codigo + " | " + Me.Clase + "        | " + Me.Seccion + " | " + Me.Horario + " | " + Me.Cupos + "    | " + Me.Profesor);
        }
        Console.ReadLine();
    }


   
}