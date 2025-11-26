using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Predicción();


    }

    private void Predicción()
    {
        string[] predicciónarray = { "Te mueres", "Te vuelves rico", "Consigues trabajo", "Exito Amoroso" };

        

        Debug.Log(predicciónarray[Random.Range(0, 4)]);
    }


}
