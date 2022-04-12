using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.

public class ej2 : MonoBehaviour
{

    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;

    // Start is called before the first frame update
    void Start()
    {
        if ((producto1 + producto2 + producto3) >= monto)
        {
            Debug.Log("Tus productos superan el monto disponible");
            Debug.Log("Te faltan " + ((producto1 + producto2 + producto3) - monto) + " pesos");
        }

        else if ((producto1 + producto2 + producto3) == monto)
        {
            Debug.Log("Tus productos salen la misma cantidad que el monto disponible");
        }

        else
        {
            Debug.Log("Tus productos no superan el monto disponible");
            Debug.Log("Te sobran " + (monto - (producto1 + producto2 + producto3)) + " pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
