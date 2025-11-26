using Unity.VisualScripting;
using UnityEngine;

public class AttackPlayerAnimator : MonoBehaviour
{

    private Animator _anim;
    [SerializeField]
    private Collider _colliderAttack;

    private void Awake()
    {


        _anim = GetComponent<Animator>();



    }


    // Update is called once per frame
    void Update()
    {


        InputAttack();


    }


    private void InputAttack()
    {

        if (Input.GetMouseButtonDown(0))
        {


            Attack();


        }
    }


    private void Attack()
    {

        _anim.SetTrigger("Attack");

    }

    private void OnEnableCollider()
    {

        //Se activa la hitbox
        _colliderAttack.enabled = true;


    }

    private void OnDisableCollider()
    {

        //Se apaga la hitbox
        _colliderAttack.enabled = false;


    }



}
