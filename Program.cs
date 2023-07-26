using System;

namespace TPFinal_Revol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
                //a. El mayor de los números pares.
                //b. La cantidad de números impares.
                //c. El menor de los números primos.

            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int numero, contPar = 0, nroMayor = 0, cont = 0, nroMin = 0, contPrimo = 0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero % 2 == 0){
                    contPar++;
                 
                if (contPar == 0){
                    nroMayor = numero;
                } else if (numero > nroMayor){
                    nroMayor = numero;
                }
                }else{
                    cont++;
                }

                if (primo(numero)){
                    
                    contPrimo++;

                if (contPrimo == 1){
                      nroMin = numero;  
                } else if (numero < nroMin){
                        nroMin = numero;
                }
                }

                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor de los numeros pares es " + nroMayor);
            Console.WriteLine("La cantidad de numeros impares es "+ cont);
            Console.WriteLine("El menor de los numeros primos es " + nroMin);
        }

        static bool primo (int nro){
            int cont = 0;

            for (int x = 1; x <= nro; x++){

                if (nro % x == 0){
                    cont++;
                }
            }

            if (cont == 2){
                return true;

            } else{

                return false;
            }
        }
    }
}
