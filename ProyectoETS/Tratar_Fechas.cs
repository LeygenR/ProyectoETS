using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoETS
{
    class Tratar_Fechas
    { 
        public static int sumarDiaBisiesto(ref bool noerror) 
        {
            string fecha1 = "10/10/-200";
            string fecha2 = "19/12/50";
            int diasSumar = 0;
            const int INICIOBISIESTO = 1582;
            string[] fechaSeparada = fecha1.Split('/');

            if (int.TryParse(fechaSeparada[2],out int anho1)) //Comprobamos que el año de la primera fecha siga siendo un número entero
            {
                fechaSeparada = fecha2.Split('/');
                if(int.TryParse(fechaSeparada[2],out int anho2)) //Comprobamos que el año de la segunda fecha siga siendo un número entero
                {      
                    if(anho1 > INICIOBISIESTO)
                    {
                        if(anho2 > INICIOBISIESTO)
                        {
                            if (anho1 > anho2) //en caso de que el segundo año sea mas pequeño que el primero, cambiamos el orden de las fechas
                            {
                                int aux = anho2;
                                anho2 = anho1;
                                anho1 = aux;
                            }

                            for (int year = anho1; anho1 <= anho2; anho1++)
                            {
                                if (DateTime.IsLeapYear(anho1)) //contamos los años bisiestos
                                {
                                    diasSumar++;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("la fecha: {0} es inferior al año {1}",fecha2, INICIOBISIESTO);
                            Console.WriteLine("No se sumarán dias adicionales, ya que fechas inferiores a {0} no cuentan para ser años bisiestos",INICIOBISIESTO);
                        }
                    }
                    else
                    {
                        Console.WriteLine("la fecha: {0} es inferior al año {1}", fecha1, INICIOBISIESTO);
                        Console.WriteLine("No se sumarán dias adicionales, ya que fechas inferiores a {0} no cuentan para ser años bisiestos", INICIOBISIESTO);
                    }
                }
                else
                {
                    noerror = true;
                    Console.WriteLine("Error de formato en el año de la fecha : " + fecha2);
                    Console.ReadKey();
                }
            }
            else
            {
                noerror = true;
                Console.WriteLine("Error de formato en el año de la fecha : "+fecha1);
                Console.ReadKey();
            }

            return diasSumar;
        }
    }
}
