using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Substraction : MonoBehaviour
{

    public int Number;



    // Start is called before the first frame update
    void Start()
    {

        SubstractionNumber();


    }
    private void SubstractionNumber()
    {

        int resta= 0;



        for (int i = 1; i <= Number; i++)
            {
                resta -= i;
            }

            Debug.Log(resta);
        }

 }
