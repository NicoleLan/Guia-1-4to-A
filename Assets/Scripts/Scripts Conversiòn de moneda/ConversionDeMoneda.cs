using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float cantidadPesos;
    public string codigoMoneda;
    float cotizacionMoneda;
    float resultadoTotal;

    // Start is called before the first frame update
    void Start()
    {
        // 2.Ingreso y validación de datos

        if (cantidadPesos < 1000) {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D"){
            cotizacionMoneda = 1200;
        } else if (codigoMoneda == "E"){
            cotizacionMoneda = 1500;
        }else if (codigoMoneda == "R"){
            cotizacionMoneda = 200;
        }else {
            Debug.Log("Opción de moneda no válida");
            return;
        }


        // 3. Procesamiento de los datos

        resultadoTotal = cantidadPesos / cotizacionMoneda;


        // 4. Salida de los datos

        Debug.Log("Monto convertido: " + resultadoTotal);
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
