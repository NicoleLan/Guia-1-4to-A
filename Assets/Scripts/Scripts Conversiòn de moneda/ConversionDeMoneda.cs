using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    public float cantidadPesos;
    public string codigoMoneda;
    float cotizacionMoneda;
    float resultadoTotal;

    float cotizacionDolar = 1200;
    float cotizacionEuro = 1500;
    float cotizacionReal = 200;
    float minimoAConvertir = 1000;
    

    // Start is called before the first frame update
    void Start()
    {
        // 2.Ingreso y validación de datos
        if (cantidadPesos < minimoAConvertir) {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D"){
            cotizacionMoneda = cotizacionDolar;
        } else if (codigoMoneda == "E"){
            cotizacionMoneda = cotizacionEuro;
        }else if (codigoMoneda == "R"){
            cotizacionMoneda = cotizacionReal;
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
