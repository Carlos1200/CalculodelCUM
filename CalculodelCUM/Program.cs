using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodelCUM
{
    class Program
    {
        static StreamReader leer;
        static StreamWriter escribir;
        static void Main(string[] args)
        {
            int x, i;
            do
            {
                Console.WriteLine("Menú");
                Console.WriteLine("1) Ingresar datos de estudiantes");
                Console.WriteLine("2) Mostrar datos");
                Console.WriteLine("3) Salir");
                x = int.Parse(Console.ReadLine());
                if (x <= 0 || x > 3)
                {
                    Console.WriteLine("Los datos ingresados no estan en el rango de 1-3");
                    Environment.Exit(0);
                }
                switch (x)
                {
                    case 1:
                        Console.Clear();
                        Datos();
                        break;
                    case 2:
                        Console.Clear();
                        Mostrar();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Ingresar 1 si desea volver al menú");
                i = int.Parse(Console.ReadLine());
            } while (i == 1);
        }
        static void Datos()
        {
            string Alumno,Carnet;
            int ciclo, x,opc;
            double CUM,cum1,cum2,cum3,cum4,cum5,cum6,cum7,cum8,cum9,cum10;
            double cum1t, cum2t, cum3t, cum4t, cum5t, cum6t, cum7t, cum8t, cum9t, cum10t;
            cum1 = 0; cum2 = 0; cum3 = 0; cum4 = 0; cum5 = 0; cum6 = 0; cum7 = 0; cum8 = 0; cum9 = 0; cum10 = 0;
            double[] Ciclo1 = new double[4], Ciclo2 = new double[5], Ciclo3 = new double[5], Ciclo4 = new double[5], Ciclo5 = new double[5], Ciclo6 = new double[4];
            double[] Ciclo7 = new double[4], Ciclo8 = new double[4], Ciclo9 = new double[4], Ciclo10 = new double[4];
            double[] Ciclo1p = new double[4], Ciclo2p = new double[5], Ciclo3p = new double[5], Ciclo4p = new double[5], Ciclo5p = new double[5], Ciclo6p = new double[4];
            double[] Ciclo7p = new double[4], Ciclo8p = new double[4], Ciclo9p = new double[4], Ciclo10p = new double[4];
            escribir = new StreamWriter("Datos.txt", true);
            
            
            Console.WriteLine("Ingrese el nombre del alumno");
            Alumno = Console.ReadLine();
            Console.WriteLine("Carnet del alumno");
            Carnet = Console.ReadLine();
            escribir.WriteLine("Nombre del alumno: {0} \n Carnet del alumno {1} ", Alumno, Carnet);
            do
            { 
            Console.Clear();
            Console.WriteLine("Ciclo del cual ingrese notas");
            Console.WriteLine("1-10");
            ciclo = int.Parse(Console.ReadLine());
            
            
            


                switch (ciclo)
                {

                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 1");
                            for (x = 0; x < Ciclo1.Length; x++)
                            {
                               
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Programacion estructurada");
                                    Ciclo1[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Quimica general");
                                    Ciclo1[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Comunicacion oral y escrita");
                                    Ciclo1[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de Calculo diferencial");
                                    Ciclo1[x] = double.Parse(Console.ReadLine());
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 2");
                            for (x = 0; x < Ciclo2.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Algebra vectorial y matrices");
                                    Ciclo2[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Calculo integral");
                                    Ciclo2[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de cinematica y dinamica de patticulas");
                                    Ciclo2[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de programacion orientada a objetos");
                                    Ciclo2[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 4)
                                {
                                    Console.WriteLine("ingresar datos de Modelamiento y diseño de base de datos");
                                    Ciclo2[x] = double.Parse(Console.ReadLine());
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 3");
                            for (x = 0; x < Ciclo3.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Electricidad y magnetismo");
                                    Ciclo3[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Calculo de varias variables ");
                                    Ciclo3[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Estadistica aplicada");
                                    Ciclo3[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de programacion con estructura de datos");
                                    Ciclo3[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 4)
                                {
                                    Console.WriteLine("ingresar datos de Analisis y diseño de sistemas informaticos");
                                    Ciclo3[x] = double.Parse(Console.ReadLine());
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 4");
                            for (x = 0; x < Ciclo4.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de ecuaciones diferenciales");
                                    Ciclo4[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Calculo avanzado ");
                                    Ciclo4[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Oscilaciones, fluidos y calor");
                                    Ciclo4[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de DatawareHouse y mineria de datos");
                                    Ciclo4[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 4)
                                {
                                    Console.WriteLine("ingresar datos de Lenguajes interpretados en el cliente");
                                    Ciclo4[x] = double.Parse(Console.ReadLine());
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 5");
                            for (x = 0; x < Ciclo5.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Analisis de circuitos");
                                    Ciclo5[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Gestion ambiental");
                                    Ciclo5[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Analisis y evaluacion economica");
                                    Ciclo5[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de Antropologia filisofica");
                                    Ciclo5[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 4)
                                {
                                    Console.WriteLine("ingresar datos de Arquitectura de computadoras");
                                    Ciclo5[x] = double.Parse(Console.ReadLine());
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 6");
                            for (x = 0; x < Ciclo6.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Direccion de proyectos");
                                    Ciclo6[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Sistemas operativos");
                                    Ciclo6[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota Pensamiento social cristiano");
                                    Ciclo6[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de Diseño de redes de datos");
                                    Ciclo6[x] = double.Parse(Console.ReadLine());
                                }

                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 7");
                            for (x = 0; x < Ciclo7.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Aplicacion de metodos numericos");
                                    Ciclo7[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Ingenieria de Sofware");
                                    Ciclo7[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Lenguajes interpretados en el servidor");
                                    Ciclo7[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de interconexion de redes de datos");
                                    Ciclo7[x] = double.Parse(Console.ReadLine());
                                }

                            }
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 8");
                            for (x = 0; x < Ciclo8.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Automatas y compiladores");
                                    Ciclo8[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Gestion de la calidad de sofware");
                                    Ciclo8[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Diseño y programacion de sofware multiplataforma");
                                    Ciclo8[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de diseño de sistemas de seguridad para redes de datos");
                                    Ciclo8[x] = double.Parse(Console.ReadLine());
                                }

                            }
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 9");
                            for (x = 0; x < Ciclo9.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Normalizacion de tecnologias de informacion");
                                    Ciclo9[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Tecnica electiva 1");
                                    Ciclo9[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Desarrollo de sofware para movil");
                                    Ciclo9[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de diseño de sistemas de seguridad para redes de datos");
                                    Ciclo9[x] = double.Parse(Console.ReadLine());
                                }

                            }
                            break;


                        }
                    case 10:
                        {
                            Console.Clear();
                            Console.WriteLine("Ciclo 10");
                            for (x = 0; x < Ciclo10.Length; x++)
                            {
                                if (x == 0)
                                {
                                    Console.WriteLine("Ingresar nota de Auditoria de sistemas");
                                    Ciclo10[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 1)
                                {
                                    Console.WriteLine("Ingresar nota de Tecnica electiva 2");
                                    Ciclo10[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 2)
                                {
                                    Console.WriteLine("Ingresar nota de Desarrollo de sofware empresarial");
                                    Ciclo10[x] = double.Parse(Console.ReadLine());
                                }
                                else if (x == 3)
                                {
                                    Console.WriteLine("Ingresar nota de administracion e implementacion de servicios de red con sistemas operativos libres");
                                    Ciclo10[x] = double.Parse(Console.ReadLine());
                                }

                            }
                            break;


                        }

                }
                Console.WriteLine("DIgite 1 si desea ingresar mas notas/ digite 2 si desea continuar");
                opc = int.Parse(Console.ReadLine());

            } while (opc == 1);
                    if (ciclo==1)
                    {
                        for (x = 0; x < Ciclo1.Length; x++)
                        {
                            if(x==0)
                            
                                Ciclo1p[x] = Ciclo1[x] * 4;

                            else if (x == 1)
                                Ciclo1p[x] = Ciclo1[x] * 4;
                            else if (x == 2)
                                Ciclo1p[x] = Ciclo1[x] * 3;
                            else if (x == 3)
                                Ciclo1p[x] = Ciclo1[x] * 4;
                        }
                    }
                    else if (ciclo == 2)
                    {
                        for (x = 0; x < Ciclo2.Length; x++)
                        {
                            if (x == 0)

                                Ciclo2p[x] = Ciclo2[x] * 3;

                            else if (x == 1)
                                Ciclo2p[x] = Ciclo2[x] * 4;
                            else if (x == 2)
                                Ciclo2p[x] = Ciclo2[x] * 4;
                            else if (x == 3)
                                Ciclo2p[x] = Ciclo2[x] * 4;
                            else if (x == 4)
                                Ciclo2p[x] = Ciclo2[x] * 4;
                        }
                    }
                    else if (ciclo == 3)
                    {
                        for (x = 0; x < Ciclo3.Length; x++)
                        {
                            if (x == 0)

                                Ciclo3p[x] = Ciclo3[x] * 4;

                            else if (x == 1)
                                Ciclo3p[x] = Ciclo3[x] * 4;
                            else if (x == 2)
                                Ciclo3p[x] = Ciclo3[x] * 4;
                            else if (x == 3)
                                Ciclo3p[x] = Ciclo3[x] * 4;
                            else if (x == 4)
                                Ciclo3p[x] = Ciclo3[x] * 4;
                        }
                    }
                    else if (ciclo == 4)
                    {
                        for (x = 0; x < Ciclo4.Length; x++)
                        {
                            if (x == 0)

                                Ciclo4p[x] = Ciclo4[x] * 4;

                            else if (x == 1)
                                Ciclo4p[x] = Ciclo4[x] * 4;
                            else if (x == 2)
                                Ciclo4p[x] = Ciclo4[x] * 4;
                            else if (x == 3)
                                Ciclo4p[x] = Ciclo4[x] * 4;
                            else if (x == 4)
                                Ciclo4p[x] = Ciclo4[x] * 4;
                        }
                    }
                    else if (ciclo == 5)
                    {
                        for (x = 0; x < Ciclo5.Length; x++)
                        {
                            if (x == 0)

                                Ciclo5p[x] = Ciclo5[x] * 4;

                            else if (x == 1)
                                Ciclo5p[x] = Ciclo5[x] * 4;
                            else if (x == 2)
                                Ciclo5p[x] = Ciclo5[x] * 4;
                            else if (x == 3)
                                Ciclo5p[x] = Ciclo5[x] * 3;
                            else if (x == 4)
                                Ciclo5p[x] = Ciclo5[x] * 4;
                        }
                    }
                    else if (ciclo == 6)
                    {
                        for (x = 0; x < Ciclo6.Length; x++)
                        {
                            if (x == 0)

                                Ciclo6p[x] = Ciclo6[x] * 4;

                            else if (x == 1)
                                Ciclo6p[x] = Ciclo6[x] * 4;
                            else if (x == 2)
                                Ciclo6p[x] = Ciclo6[x] * 3;
                            else if (x == 3)
                                Ciclo6p[x] = Ciclo6[x] * 4;
                        }
                    }
                   else if (ciclo == 7)
                    {
                        for (x = 0; x < Ciclo7.Length; x++)
                        {
                            if (x == 0)

                                Ciclo7p[x] = Ciclo7[x] * 3;

                            else if (x == 1)
                                Ciclo7p[x] = Ciclo7[x] * 3;
                            else if (x == 2)
                                Ciclo7p[x] = Ciclo7[x] * 4;
                            else if (x == 3)
                                Ciclo7p[x] = Ciclo7[x] * 4;
                        }
                    }
                   else if (ciclo == 8)
                    {
                        for (x = 0; x < Ciclo8.Length; x++)
                        {
                            if (x == 0)

                                Ciclo8p[x] = Ciclo8[x] * 3;

                            else if (x == 1)
                                Ciclo8p[x] = Ciclo8[x] * 3;
                            else if (x == 2)
                                Ciclo8p[x] = Ciclo8[x] * 4;
                            else if (x == 3)
                                Ciclo8p[x] = Ciclo8[x] * 4;
                        }
                    }
                   else if (ciclo == 9)
                    {
                        for (x = 0; x < Ciclo9.Length; x++)
                        {
                            if (x == 0)

                                Ciclo9p[x] = Ciclo9[x] * 4;

                            else if (x == 1)
                                Ciclo9p[x] = Ciclo9[x] * 4;
                            else if (x == 2)
                                Ciclo9p[x] = Ciclo9[x] * 4;
                            else if (x == 3)
                                Ciclo9p[x] = Ciclo9[x] * 4;
                        }
                    }
                   else if (ciclo == 10)
                    {
                        for (x = 0; x < Ciclo10.Length; x++)
                        {
                            if (x == 0)

                                Ciclo10p[x] = Ciclo10[x] * 4;

                            else if (x == 1)
                                Ciclo10p[x] = Ciclo10[x] * 4;
                            else if (x == 2)
                                Ciclo10p[x] = Ciclo10[x] * 4;
                            else if (x == 3)
                                Ciclo10p[x] = Ciclo10[x] * 4;
                        }
                    }

            for (x = 0; x < 10; x++)
            {
                if (x == 1)
                {
                    for (x = 1; x < Ciclo1.Length; x++)
                    {
                        cum1 = cum1 + Ciclo1p[x];

                    }

                }
                else if (x == 2)
                {
                    for (x = 1; x < Ciclo2.Length; x++)
                    {
                        cum2 = cum2 + Ciclo2p[x];
                    }

                }
                else if (x == 3)
                {
                    for (x = 1; x < Ciclo3.Length; x++)
                    {
                        cum3 = cum3 + Ciclo3p[x];
                    }

                }
                else if (x == 4)
                {
                    for (x = 1; x < Ciclo4.Length; x++)
                    {
                        cum4 = cum4 + Ciclo4p[x];
                    }

                }
                else if (x == 5)
                {
                    for (x = 1; x < Ciclo5.Length; x++)
                    {
                        cum5 = cum5 + Ciclo5p[x];
                    }

                }
                else if (x == 6)
                {
                    for (x = 1; x < Ciclo6.Length; x++)
                    {
                        cum6 = cum6 + Ciclo6p[x];
                    }

                }
                else if (x == 7)
                {
                    for (x = 1; x < Ciclo7.Length; x++)
                    {
                        cum7 = cum7 + Ciclo7p[x];
                    }

                }
                else if (x == 8)
                {
                    for (x = 1; x < Ciclo8.Length; x++)
                    {
                        cum8 = cum8 + Ciclo8p[x];
                    }

                }
                else if (x == 9)
                {
                    for (x = 1; x < Ciclo9.Length; x++)
                    {
                        cum9 = cum9 + Ciclo9p[x];
                    }

                }
                else if (x == 10)
                {
                    for (x = 1; x < Ciclo10.Length; x++)
                    {
                        cum10 = cum10 + Ciclo10p[x];
                    }

                }
            }
                cum1t = cum1 / 15;
            escribir.WriteLine("CUM ciclo 1: {0}", cum1t);
                cum2t = cum2 / 19;
            escribir.WriteLine("CUM ciclo 2: {0}", cum2t);
            cum3t = cum3 / 20;
            escribir.WriteLine("CUM ciclo 3: {0}", cum3t);
            cum4t = cum4 / 20;
            escribir.WriteLine("CUM ciclo 4: {0}", cum4t);
            cum5t = cum5 / 19;
            escribir.WriteLine("CUM ciclo 5: {0}", cum5t);
            cum6t = cum6 / 15;
            escribir.WriteLine("CUM ciclo 6: {0}", cum6t);
            cum7t = cum7 / 14;
            escribir.WriteLine("CUM ciclo 7: {0}", cum7t);
            cum8t = cum8 / 14;
            escribir.WriteLine("CUM ciclo 8: {0}", cum8t);
            cum9t = cum9 / 20;
            escribir.WriteLine("CUM ciclo 9: {0}", cum9t);
            cum10t = cum10 / 20;
            escribir.WriteLine("CUM ciclo 10: {0}", cum10t);
            CUM = (cum1t + cum2t + cum3t + cum4t + cum5t + cum6t + cum7t + cum8t + cum9t + cum10t) / 10;
                Console.WriteLine("EL cum final es de: {0}", CUM);
                escribir.WriteLine(CUM);
                escribir.Close();
            
            
            
        }
        static void Mostrar()
        {
            Process.Start("Datos.txt");
            leer = new StreamReader("Datos.txt", true);
            Console.WriteLine(leer.ReadToEnd());
            leer.Close();
            Console.ReadKey();
        }
        

    }
}

