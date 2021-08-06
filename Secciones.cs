using System;

public class Secciones
{
    public string Seccion { get; set; }
    public string Profesor { get; set; }
    public string Horario { get; set; }
    public int Cupos { get; set; }
    public string HI { get; set; }
    public string HF { get; set; }
    public string Edificio { get; set; }

    public Secciones(string seccion, string Hi, string Hf, string horario, string edificio, int cupos, string profesor)
    {
        Seccion = seccion;
        HI = Hi;
        HF = Hf;
        Edificio = edificio;
        Profesor = profesor;
        Horario = horario;
        Cupos = cupos;
    }
}