using UnityEngine;

public class CameraMovementPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    
    
    [SerializeField]
    //Velocidad seguimiento camara
    private float _smoothing;
    [SerializeField]
    //Distancia incial
    private Vector3 _offset;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        _offset = transform.position - _target.position;


    }

    // Update is called once per frame
    private void LateUpdate()
    {

        Vector3 desiredPosition = _target.position + _offset;
        

        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);


    }
}
