/*le da 3 oportunidad al usuario de ingresar los numeros de los cuales los busca en el array y les dice
cuantos de los numeros que ingreso (3) acerto*/

using System;

namespace ej_6_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arreglo ={25, 32 , 1, 99, 100, 125, 951, 456, 754, 10};
            int [] arregloUsuario=new int[3];
            int num=0, oportunidad=3, aciertos=0, j=0;
            


            do{

                Console.WriteLine("Ingrese por favor el numero que desea buscar: ");
                num=Convert.ToInt32(Console.ReadLine());

                arregloUsuario[j]=num;
                j=j+1;

                for(int i=0 ; i<10; i++){
                    if(arreglo[i]==num && oportunidad !=0){
                        aciertos=aciertos+1;
                    }  
                }
                oportunidad=oportunidad-1;
            
            }while(oportunidad !=0);

            Console.Clear();
            Console.WriteLine("Usted ingreso los siguientes numeros: ");

            for(int i=0; i<3;i++){
                Console.Write(arregloUsuario[i] + " | ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" LOS NUMEROS SON:  ");
            for(int i=0; i<10;i++){
                Console.Write(arreglo[i] + " | ");
            }
            Console.WriteLine(" ");
             Console.WriteLine(" ACIERTOS ->  " + aciertos);

        }
    }
}
