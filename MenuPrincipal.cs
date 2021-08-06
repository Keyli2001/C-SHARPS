using System;

public class MenuPrincipal
{
    public void menu()
    {
        MenuSecundario M2 = new MenuSecundario();
        AdicionarAsig Ad = new AdicionarAsig();
        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("         DIRECCION DE INGRESO PERMANECIA Y PROMOCION DIPP - UNAH");
            Console.WriteLine("==========================================================================");
            Console.WriteLine("");
            Console.WriteLine("         1 - Adicionar asignatura      |  4 - Ver Departamentos");
            Console.WriteLine("         2 - Cancelar asignatura       |  5 - Ver Asignaturas ");
            Console.WriteLine("         3 - Formar 03                 |  6 - Ver Secciones");
            Console.WriteLine("         0 - Cerrar Sesion             |  7 - Ver Clases Matriculadas");
            Console.WriteLine("");
            Console.Write("Ingrese una opcion: ");
            opcion = Console.ReadLine();
            
            switch (opcion)
            {
                
                case "1":
                Ad.MatricularClase();
                    break;
                case "2":
                    Ad.Cancelar();
                    break;
                case "3":
                    Ad.Forma03();
                    break;
                case "4":
                   Ad.MostrarDepto();
                    break;
                case "5":
                   Ad.Asi();
                    break;
                case "6":
                    Ad.Sec();
                    break;
                case "7":
                    Ad.PreMatricula();
                    break;
                default:
                break;
            }
            
            if (opcion.ToLower() == "0")
                {
                    break;
                }
        }
        
    }






}