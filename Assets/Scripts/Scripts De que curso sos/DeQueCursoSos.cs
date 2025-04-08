using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeQueCursoSos : MonoBehaviour
{
    public string studentName;
    public int studentYear;
    public string studentOrientation;

    // Start is called before the first frame update
    void Start()
    {
        if ((studentName == "") || (studentYear > 5) || (studentOrientation != "T" && studentOrientation != "D" && studentOrientation == "G" && studentOrientation != "M" && studentOrientation !="H" ))
        {
            Debug.Log("Por favor revise si es válida la información ingresada.");
            return;
        }else if (studentYear <3 && studentOrientation != "")
        {
            Debug.Log("Error, el alumno pertenece a ciclo básico, no puede tener orientación.");
            return;
        }else
        {
            Debug.Log("Muchas gracias " + studentName);
        }
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
