using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


        TrueFalseArray();



    }


    private void TrueFalseArray()
    {

        bool[] booleanarray = { false , false , false };

        booleanarray[0] = true;

        for (int i = 0; i < booleanarray.Length; i++) 
        { 


            Debug.Log(booleanarray[i]);


        } 


    }




}
