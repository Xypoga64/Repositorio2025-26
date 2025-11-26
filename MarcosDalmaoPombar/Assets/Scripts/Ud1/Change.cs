using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        GetNumbers();


    }

    private void GetNumbers()
    {
        int[] numbersarray = { 1, 1, 1, 1, 1 };

        numbersarray[0] = 42;
        numbersarray[4] = 42;

        Debug.Log(numbersarray.Length);


        for (int i = 0; i < numbersarray.Length; i++)
        {
        
        
            Debug.Log(numbersarray[i]);
        
        
        }



    }

}
