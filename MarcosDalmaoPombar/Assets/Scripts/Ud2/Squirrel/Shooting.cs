using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Zona de variables 
    [SerializeField]
    private GameObject _egg;
    [SerializeField]
    private Transform _posRotRabbit;
    [SerializeField]
    private float _thrustY;
    [SerializeField]
    private float _thrustZ;
    [SerializeField]
    private float _timeDestroy;




    // Update is called once per frame
    void Update()
    {


        CreateEgg();


    }

    private void CreateEgg()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //Prefabs Instanciados
            GameObject cloneEgg = Instantiate(_egg, _posRotRabbit.position, _posRotRabbit.rotation);

            Rigidbody rbEgg = cloneEgg.GetComponent<Rigidbody>();

            Destroy(cloneEgg, _timeDestroy);

            //Fuerzas al prefab 
            rbEgg.AddForce(Vector2.up * _thrustY);
            rbEgg.AddForce(transform.forward * _thrustZ);


        }



    }

}




