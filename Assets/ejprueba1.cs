using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear un algoritmo que permita al usuario convertir una cantidad de dinero en pesos argentinos a su equivalente
//moneda extranjera. Se debe poder ingresar por Inspector el monto a convertir y una letra correspondiente a la 
//moneda extranjera que se quiera convertir, las opciones son: D, para dolares R, para reales E, para euros
//(La cotizacion de la moneda sera investigada por quien realice el examen)
//El programa debe cumplir los siguientes requerimientos: Si ingresa otra cosa que no sea "D", "R" o "E", se debe
//mostrar el mensaje "Opcion no valida"
//Si la cantidad de dinero a convertir es menor a 1000, mostrar el mensaje "El monto minimo es $1000"
//Si los valores ingresado son validos devolver el mensaje "[Monto a convertir pesos argentinos equivalen a [cantidad 
//convertida][moneda elegifda]". Ejemplo "1000 pesos equivalen a 3 dolares"


public class ejprueba1 : MonoBehaviour
{
    public float monto;
    public string letra;

    // Start is called before the first frame update
    void Start()
    {
        if (monto < 1000)
        {
            Debug.Log("El monto minimo es $1000");
        }

        else
        {
            switch (letra)
            {
                case "D":
                    Debug.Log(monto + " equivalen a " + (monto / 112.53) + " dolares");
                    break;

                case "R":
                    Debug.Log(monto + " equivalen a " + (monto / 23.97) + " reales");
                    break;

                case "E":
                    Debug.Log(monto + " equivalen a " + (monto / 112.23) + " euros");
                    break; 

                default:
                    Debug.Log("Opcion no valida");
                    break;
            }
        }

        
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
