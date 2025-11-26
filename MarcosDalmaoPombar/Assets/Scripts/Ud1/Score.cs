using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public float ScoreGot;
    private float ScoreNeed = 45;






    // Start is called before the first frame update
    void Start()
    {

        Result(ScoreGot , ScoreNeed);


    }

    private void Result(float NumberGot, float NumberNeed)
    {
        if (NumberGot >= NumberNeed)
        {

            Debug.Log("Enhorabuena has superado la puntuacion");


        }
        else 
        {


            Debug.Log("No has superado la puntuación necesaria");
        
        
        }



    }



}
