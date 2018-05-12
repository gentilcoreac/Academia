using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio
        {
            get { return _UsuarioNegocio; }
            set { _UsuarioNegocio = value; }
        }

        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }


        public void Menu()
        {
            ConsoleKeyInfo opcion;

            do
            {
                Console.Clear();
                Console.Write("\tMENU: " +
                "\n\t1– Listado General" +
                "\n\t2– Consulta " +
                "\n\t3– Agregar" +
                "\n\t4- Modificar" +
                "\n\t5- Eliminar" +
                "\n\t6- Salir" +
                "\n\n\tIngrese una opcion: ");

                opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        this.ListadoGeneral();
                        Console.WriteLine("\n\n(Presione una tecla para continuar)");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        this.Consultar();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine("\n\nMETODO NO IMPLEMENTADO");

                        //  Agregar();

                        Console.WriteLine("\n\n(Presione una tecla para continuar)");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                        this.Modificar();
                        Console.WriteLine("\n\n(Presione una tecla para continuar)");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D5:
                        Console.WriteLine("\n\nMETODO NO IMPLEMENTADO");

                        // Eliminar();
                        Console.WriteLine("\n\n(Presione una tecla para continuar)");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D6:
                        Console.WriteLine("\n\nFin del programa");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nOpcion incorrecta");
                        Console.WriteLine("\n\n(Presione una tecla para continuar)");
                        Console.ReadKey();
                        break;
                }
            } while (opcion.KeyChar != '6');

            Console.ReadKey();
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            Console.WriteLine("          Listado General \n");
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("          Usuario {0}", usr.ID);
            Console.WriteLine("           Nombre {0}", usr.Nombre);
            Console.WriteLine("         Apellido {0}", usr.Apellido);
            Console.WriteLine("Nombre de usuario {0}", usr.NombreUsuario);
            Console.WriteLine("            Clave {0}", usr.Clave);
            Console.WriteLine("            Email {0}", usr.Email);
            Console.WriteLine("       Habilitado {0}", usr.Habilitado);

            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
            Console.Clear();
            Console.WriteLine("Ingrese el ID del usuario a consultar: ");
            int ID = int.Parse(Console.ReadLine());
            this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\nError: El ID ingresado debe ser un número entero\n" + fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: \n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nPresione una tecla para continuar ");
                Console.ReadKey();
            }
        }
        public void Modificar()
        {
            try
            {
            Console.Clear();
            Console.Write("Ingrese el ID del usuario a modificar: ");
            int ID = int.Parse(Console.ReadLine());
            Usuario usuario = UsuarioNegocio.GetOne(ID);
            Console.WriteLine("\nLos datos actuales del usuario son: ");
            this.MostrarDatos(UsuarioNegocio.GetOne(ID));

            Console.WriteLine("\nIngrese los nuevos valores: ");
            Console.Write("Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Nombre de usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Habilitación de Usuario (1-Si / otro-No): ");
            usuario.Habilitado = (Console.ReadLine()=="1");
            usuario.State = BusinessEntity.States.Modified;
            UsuarioNegocio.Save(usuario);
            }
            catch(FormatException fee)
            {
                Console.WriteLine("\nError: El ID ingresado debe ser un número entero\n" + fee.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: \n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nPresione una tecla para continuar ");
                Console.ReadKey();
            }
        }
    }
}
