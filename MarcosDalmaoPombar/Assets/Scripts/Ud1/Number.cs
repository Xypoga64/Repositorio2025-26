using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    [SerializeField]
    public float InputNumber;
    private float AdditionNumber = 1;




    // Start is called before the first frame update
    void Start()
    {

        Addition(InputNumber , AdditionNumber);


    }

    private void Addition(float NumberOne, float NumberTwo)
    {

        float result = NumberOne + NumberTwo;

        Debug.Log("El siguiente número al introducido es: " + result);


    }


}
