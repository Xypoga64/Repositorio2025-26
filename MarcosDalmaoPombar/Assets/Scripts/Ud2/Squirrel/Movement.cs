using TMPro.EditorUtilities;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Zona de variables
    [SerializeField]
    private float _speed = 1.0f;
    [SerializeField]
    private float _turnspeed = 90.0f;
    [SerializeField]
    private float _vertical;
    [SerializeField]
    private float _horizontal;



    // Update is called once per frame
    void Update()
    {


        InputMovement();


    }

    private void InputMovement()
    {


        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);

        transform.Rotate(Vector3.up * _horizontal * _turnspeed * Time.deltaTime);
    }





}



