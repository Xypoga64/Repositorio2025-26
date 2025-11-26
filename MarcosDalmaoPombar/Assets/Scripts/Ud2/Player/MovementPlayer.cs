using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _turnSpeed;

    private float _horizontal;
    private float _vertical;

    private Animator _anim;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField]
    private float _rayLength;
    [SerializeField]
    private LayerMask _rayMask;

    private Rigidbody _rb;
    [SerializeField]
    private float _forcejump;
    private bool _isGrounded;
    private bool _canJump;


    private void Awake()
    {

        //Conseguir el componente para que funcionen las animaciones
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();

    }
    //FixedUpdate es el que se dedica a las fisicas
    private void FixedUpdate()
    {
        LaunchRaycast();
        if (_canJump == true)
        {
            _canJump = false;
            Jump();

        }
    }

    // Update is called once per frame
    void Update()
    {

        InputsPlayer();
        Move();
        Turn();
        Animating();
        CanJump();

    }



    //El launch raycast se pone en FixedUpdate
    private void LaunchRaycast()
    {
        //Formar el raycast hacia abajo
        _ray.origin = transform.position;
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, _rayLength, _rayMask))
        {
            //Que detecte que esta tocando suelo poniendo el booleando en true
            _isGrounded = true;


        }
        else
        {

            _isGrounded = false;

        }
        Debug.DrawRay(_ray.origin, _ray.direction * _rayLength, Color.red);

    }

    private void CanJump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            //Como el rayo detecta el suelo el booleano de grounded se pone en true
            //activando el booleando de que se pueda saltar
            _canJump = true;

        }
    }
    private void Jump()
    {


        _rb.AddForce(Vector3.up * _forcejump);


    }
    private void InputsPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");



    }

    private void Move()
    {

        transform.Translate(Vector3.forward * _vertical * _speed * Time.deltaTime);


    }

    private void Turn()
    {

        transform.Rotate(Vector3.up * _horizontal * _turnSpeed * Time.deltaTime);


    }



    private void Animating()
    {


        if (_vertical != 0)
        {


            _anim.SetBool("IsMoving", true);


        }
        else
        {


            _anim.SetBool("IsMoving", false);


        }

    }

}
