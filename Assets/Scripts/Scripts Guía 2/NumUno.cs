using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumUno : MonoBehaviour
{
    int numUno = 0;
    // Start is called before the first frame update
    void Start()
    {
        numUno += 2;
        Debug.Log(numUno);
        numUno *= numUno;
        Debug.Log(numUno); // o Debug.Log (numUno *= numUno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
