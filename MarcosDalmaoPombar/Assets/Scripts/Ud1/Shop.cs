using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    [SerializeField]
    public int PotatoUnits;
    [SerializeField]
    public int PotatoUnitsAdded;
    [SerializeField]
    public int BrecolUnits;
    [SerializeField]
    public int BrecolUnitsAdded;
    [SerializeField]
    private bool _isAddition;
    [SerializeField]
    private bool _isSubtraction;


    // Start is called before the first frame update
    void Start()
    {


        Operations();


    }

    private void Operations()
    {


        if (_isAddition == true)
        {


            GetAddition(PotatoUnits, PotatoUnitsAdded, BrecolUnits, BrecolUnitsAdded);



        }
        if (_isSubtraction == true)
        {


            GetSubtraction(PotatoUnits, PotatoUnitsAdded, BrecolUnits, BrecolUnitsAdded);


        }



    }

    private void GetAddition(int Potato, int PotatoAdded, int Brecol, int BrecolAdded)
    {

        int resultpotato = Potato + PotatoAdded;

        Debug.Log(" Tenemos esta " + resultpotato + " de patatas ");

        int resultbrecol = Brecol + BrecolAdded;

        Debug.Log("Tenemos esto " + resultbrecol + " de brecol");


    }

    private void GetSubtraction(int Potato, int PotatoAdded, int Brecol, int BrecolAdded)
    {

        int resultpotato = Potato - PotatoAdded;

        Debug.Log(" Tenemos esta " + resultpotato + " de patatas ");

        int resultbrecol = Brecol - BrecolAdded;

        Debug.Log("Tenemos esto " + resultbrecol + " de brecol");


    }

}
