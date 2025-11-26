using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _objective;


    // Update is called once per frame
    void Update()
    {

        LookObjective();


    }

    private void LookObjective() 
    {
    
    
        transform.LookAt(_objective);
    
    
    }
}
