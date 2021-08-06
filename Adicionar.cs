using System;
using System.Collections.Generic;
using System.Threading;

public class AdicionarAsig
{

    public List<Departamentos> ListadeDepto { get; set; }
    public List<Asignaturas> ListadeAsignaturas { get; set; }
    public List<Secciones> ListadeSecciones { get; set; }
    public List<Alumno> Alum { get; set; }
    public List<AgregarAsig> ListadeMatricula { get; set; }
    public List<AgregarAsig> Cancelado { get; set; }
    
    public AdicionarAsig()
    
    {
        ListadeDepto = new List<Departamentos>();
        CargarDeptos();
        ListadeAsignaturas = new List<Asignaturas>();
        CargarAsig();
        ListadeSecciones = new List<Secciones>();
        CargarSecciones();
        Alum = new List<Alumno>();
        MirarAlum();

        ListadeMatricula = new List<AgregarAsig>();
        Cancelado = new List<AgregarAsig>();
    }

    private void MirarAlum()
    {
    
        Alumno a = new Alumno(20192001134, "Alex Issai Matamoros Fuentes",12345,"Informatica Administrativa");
        Alum.Add(a);
    }
    private void CargarDeptos()
    {
        Departamentos D1 = new Departamentos(01, "Informatica Adiministrativa");
            ListadeDepto.Add(D1);
        Departamentos D2 = new Departamentos(02, "Contaduria");
            ListadeDepto.Add(D2);
        Departamentos D3 = new Departamentos(03, "Historia");
            ListadeDepto.Add(D3);

    }
    private void CargarAsig()
    {
        Asignaturas A1 = new Asignaturas("IA-012", "Introduccion a Informatica ");
            ListadeAsignaturas.Add(A1);
        Asignaturas A2 = new Asignaturas("IA-023", "Taller de Hardawe I        ");
            ListadeAsignaturas.Add(A2);
        Asignaturas A3 = new Asignaturas("IA-033", "Metodologia de Programacion");
            ListadeAsignaturas.Add(A3);

    }
    private void CargarSecciones()
    {
            Secciones s1 = new Secciones("0700","07","08","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s1);
            Secciones s2 = new Secciones("0701","07","08","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s2);
            Secciones s3 = new Secciones("0800","08","09","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s3);
            Secciones s4 = new Secciones("0801","08","09","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s4);
            Secciones s5 = new Secciones("0900","09","10","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s5);
            Secciones s6 = new Secciones("0901","09","10","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s6);
            Secciones s7 = new Secciones("1000","10","11","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s7);
            Secciones s8 = new Secciones("1001","10","11","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s8);
            Secciones s9 = new Secciones("1100","11","12","LuMaMiJu","Edificio 5",30, "Bily Fernandez");
        ListadeSecciones.Add(s9);
    }

    public void LiAlumnos()
    {

        foreach (var Al in Alum)
        {
            Console.WriteLine(Al.NumeroCuenta + "," + Al.Nombre + "," + Al.Carrera);
        }
    }
    public void MostrarDepto()
    {
        Console.Clear();
        Console.WriteLine("               D E P A R T A M E N T O S");
        Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("___________________________________");
            Console.WriteLine(" Cod |         Nombre Dep          |");
            Console.WriteLine("_____|_____________________________|");

        foreach (var De in ListadeDepto)
        {
            Console.WriteLine(De.Codigo + "    | " + De.Nombre_Dep);
        }
        Console.ReadLine();
    }

    public void MostrarAsig()
    {

            Console.WriteLine("_______________________________________");
            Console.WriteLine(" Cod   |         Nombre Asig          |");
            Console.WriteLine("_______|______________________________|");
        foreach (var As in ListadeAsignaturas)
        {
            Console.WriteLine(As.Codigo_Clase + " | " + As.Clase);
        }
        Console.ReadLine(); 
    }

    public void MostrarSecc()
    {
            Console.WriteLine("____________________________________");
            Console.WriteLine("Secc |  Horario |Cupo| Profesor     |");
            Console.WriteLine("_____|__________|____|______________|");
        foreach (var Se in ListadeSecciones)
        {
            Console.WriteLine(Se.Seccion + " | " + Se.Horario + " | " + Se.Cupos + " | " + Se.Profesor);
        }
        Console.ReadLine(); 
    }
    
    //////////////////////////////////////
    public void intro(){
        Console.Clear();
        Console.WriteLine("                           B I E N V E N I D O");
        Console.WriteLine("---------------------------------------------------------------------------------");
        
        Console.WriteLine("");
        
    }
    public void Asi()
    {
        Console.Clear();
        Console.WriteLine("               A S I G N A T U R A S");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("Ingrese el Codigo del Departamento: ");
        string CoD = Console.ReadLine();
        Departamentos Dept = ListadeDepto.Find(a => a.Codigo.ToString() == CoD);
        if (Dept == null)
        {
            Console.WriteLine("Parece que no existe ese Departamento");
            Console.ReadLine();
            return;
        }
        else{
            Console.WriteLine("Asignaturas del Departamento: " + Dept.Nombre_Dep);
            Console.WriteLine("");
        }
        MostrarAsig();

    }
    public void Sec()
    {
        Console.Clear();
        Console.WriteLine("                   S E C C I O N E S");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("");
        Console.Write("Ingrese el codigo de la Asignatura: ");
        string CodigoA = Console.ReadLine();
        Asignaturas As = ListadeAsignaturas.Find(A => A.Codigo_Clase == CodigoA);
            if (As == null)
            {
                Console.WriteLine("Parece que no existe esta Asignatura");
                Console.ReadLine();
                Console.WriteLine("");
                return;
            } 
            else
            {
                Console.WriteLine("Secciones de la asignatura " + As.Clase);
                Console.WriteLine("");

            }
        MostrarSecc();
    }
    public void Login()
    {
        intro();
        MenuPrincipal men = new MenuPrincipal();
        Boolean Login = false;
        Console.WriteLine("---------------- Ingresa tu numero de cuenta y clave ------------------------------");
        Console.WriteLine("");   
        Console.Write("         Numero de Cuenta: "); string Ncue = Console.ReadLine();
        Console.Write("         Ingrese la Clave: "); string con = Console.ReadLine();
        
        if (Ncue != "20192001134" && con != "1234")
        {
            Login=false;
            while(Login == false)
            {
            intro();
            Console.WriteLine("Los datos no coinciden, por favor ingrese los correctos");
            Console.ReadLine();
            Console.Clear();
            intro();
            Console.Write("     Numero de Cuenta: "); Ncue = Console.ReadLine();
            Console.Write("     Ingrese la Clave: "); con = Console.ReadLine();
            //return;
            if (Ncue != "20192001134" && con != "1234")
            {
                Login=false;
            } else {
                Login = true;
            }
        }
        } else {
            Login= true;
        }
        
        while(Login == false)
        {
            Console.WriteLine("Los datos no coinciden");
        }
            Console.WriteLine("Datos Correctos...");
            escribirPBar();
            men.menu();  
            Console.ReadKey();
                 
        }
    public  void escribirPBar() 
    {
        int contador = 0;
        int contador2 = 0;
        int stop = 100;
        while (contador2 <= stop)
        {
            Console.Clear();
            intro();
            Console.SetCursorPosition(2,2);
            Console.WriteLine("Espere...");
            Console.Write(    "Cargando "+ contador2 + "%");
            Thread.Sleep(1);
            contador2++;

            if (contador < 100)
            {
               Console.SetCursorPosition(contador2,4);
               Thread.Sleep(30);
               Console.Write("|");
            }
               
        contador++;
        }
       
    }
   
    private void MovimientoCupos(string nseccion,string tipoMov)
    {
        foreach (var S in ListadeSecciones)
        {
            if (S.Seccion == nseccion)
            {
                if (tipoMov == "+")
                {
                    S.Cupos = S.Cupos + 1;
                } else {
                    S.Cupos = S.Cupos - 1;
                }
            }
        }
    }
    public void MatricularClase()
    {
        Console.Clear();
        Console.WriteLine("                   M a t r i c u l a");
        Console.WriteLine("--------------------------------------------------------------");
       
        Console.Write("Ingrese el codigo del Departamento: ");
        string codigoDe = Console.ReadLine();
        Departamentos Depto = ListadeDepto.Find(a => a.Codigo.ToString() == codigoDe);
        if (Depto == null)
        {
            Console.WriteLine("Parece que no existe ese Departamento");
            Console.ReadLine();
            return;
        }
        else{
            Console.WriteLine("Departamento: " + Depto.Nombre_Dep);
            Console.WriteLine("");
        }

            Console.Write("Ingrese el codigo de la Asignatura: ");
            string codigoAs = Console.ReadLine();
            
            Asignaturas Asig = ListadeAsignaturas.Find(A => A.Codigo_Clase == codigoAs);
            AgregarAsig As = ListadeMatricula.Find(s => s.CodigoClase == codigoAs);
            if (Asig == null)
            {
                Console.WriteLine("Parece que no existe esta Asignatura");
                Console.ReadLine();
                return;
            } 
            foreach (var a in ListadeMatricula)
            {
                if (a.CodigoClase == codigoAs)
                {
                    Console.WriteLine("Ya tienes matriculada esa clase");
                    Console.ReadLine();
               return;
                }
            else{
                Console.WriteLine("Asignatura Agragada: " + Asig.Clase);
                Console.WriteLine("");

            }
           } 

            AgregarAsig Matri = new AgregarAsig(Depto, Asig);
            ListadeMatricula.Add(Matri);
        while (true)
        {  
            Console.Write("Ingrese la Seccion: ");
            string Secci = Console.ReadLine();
            Secciones secciones = ListadeSecciones.Find(s => s.Seccion == Secci);
            if (secciones ==  null)
            {
                Console.WriteLine("Seccion No Disponible");
                Console.ReadLine();
                return;
            } 
            else{
                Console.WriteLine("Seccion Disponible: " + secciones.Seccion + "," + secciones.Horario + "," + secciones.Profesor);
                Matri.AgragarAsignatura(Asig,secciones);
                MovimientoCupos(Secci,"-");
                
            }
           
            Console.WriteLine("");
            Console.WriteLine("___________________________________________________________________________________________________");
            Console.WriteLine("La Asignaturas seleccionada es: " + Matri.SeccionesM);
            Console.ReadLine();
            return;
        }
            
    }

    ///////////////////////////// CANCELAR ASIGNATURA /////////////////////////

    public void Cancelar()
    {
        Console.Clear();
        Console.WriteLine("              C A N C E L A R    C L A S E              ");
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("");
        Console.Write("Ingrese el codigo de la clase: ");
        string Codigoc = Console.ReadLine();
        Console.Write("Ingrese la seccion: ");
        string secc = Console.ReadLine();
        foreach (var C in ListadeMatricula)
        {
            if (C.CodigoClase == Codigoc)
            {
               ListadeMatricula.Remove(C);
               Console.WriteLine("");
               Console.WriteLine("Asignatura Cancelada: "+ C.CodigoClase + ", " + C.ParaNombre + ", " + C.ParaSecciones); 
               
            } if (C.ParaSecciones == secc)
            {
                MovimientoCupos(secc,"+");
                break;
            }
            
        }
        
        Console.ReadLine();
    }

    public void PreMatricula()
    {
        Console.Clear();
            //Alumno j = new Alumno(20192001134, "Alex Issai Matamoros Fuentes", 1234,"Informatica Administrativa");
            Console.WriteLine("                           M A T R I C U L A                               ");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("                         Asignaturas Matriculadas");
            //Console.WriteLine("Nombre:           "+ j.Nombre);
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine(" Cod   |          Asignatura        | Secc  | HI  | HF   | Horario    | Edificio    |");
            Console.WriteLine("_______|____________________________|_______|_____|______|____________|_____________|");
        foreach (var Mat in ListadeMatricula)
        {
         
            Console.WriteLine(Mat.CodigoClase + " | "+ Mat.ParaNombre +"|" + Mat.ParaSecciones + "   |" + Mat.HoraIni + "   |" + Mat.Horafi + "    |" + Mat.ParaHorario + "    |" + Mat.Edi + "   |");
        }
        Console.ReadLine();
    }


    ////////////////////
       public void Forma03()
    {
        Console.Clear();
            Alumno j = new Alumno(20192001134, "Alex Issai Matamoros Fuentes", 1234,"Informatica Administrativa");
            Console.WriteLine("                           M A T R I C U L A                               ");
            Console.WriteLine("================================================================================");
            Console.WriteLine("Nombre:           "+ j.Nombre + "             Carrera:" + j.Carrera);
            Console.WriteLine("Numero de Cuenta: "+j.NumeroCuenta);
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine(" Cod   |          Asignatura        | Secc  | HI  | HF   | Horario    | Edificio    |");
            Console.WriteLine("_______|____________________________|_______|_____|______|____________|_____________|");
        foreach (var Mat in ListadeMatricula)
        {
         
            Console.WriteLine(Mat.CodigoClase + " | "+ Mat.ParaNombre +"|" + Mat.ParaSecciones + "   |" + Mat.HoraIni + "   |" + Mat.Horafi + "    |" + Mat.ParaHorario + "    |" + Mat.Edi + "   |");
        }

        Console.ReadLine();     
    }

        
}
        

