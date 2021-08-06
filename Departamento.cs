using System;

public class Departamentos
{
    public string Nombre_Dep { get; set; }
    public int Codigo { get; set; }

    public Departamentos(int codigo, string nombre_Dep)
    {
        Nombre_Dep = nombre_Dep;
        Codigo = codigo;
    }
}