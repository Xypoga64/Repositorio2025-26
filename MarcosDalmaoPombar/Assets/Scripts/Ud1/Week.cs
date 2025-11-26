using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week : MonoBehaviour
{
    public int Daynumber;




    // Start is called before the first frame update
    void Start()
    {


        WhatWeekday();



    }





    private void WhatWeekday()
    {


        switch (Daynumber)
        {
            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miercoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sabado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("Numero introducido no es un dia de la semana");
                break;
        }


    }

}
