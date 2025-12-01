using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_move : MonoBehaviour
{
    [SerializeField] GameObject Body;
    [SerializeField] float Speed;
    [SerializeField] float Roteto;
    [SerializeField] CinemachineCamera Camera;
    Rigidbody rb;

    //--------
    Vector2 Inputvec;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue input)
    {
        Inputvec = input.Get<Vector2>();
    }

    private void Update()
    {
        rb.linearVelocity = new Vector3(Inputvec.x * Speed, rb.linearVelocity.y, Inputvec.y * Speed);


        //------  ------
        if (Inputvec.magnitude < 0.1f){
            return;
        }


        var angle = Mathf.Atan2(Inputvec.x, Inputvec.y) * Mathf.Rad2Deg;
        var q = Quaternion.Euler(0, angle, 0);
        Body.transform.localRotation = Quaternion.RotateTowards(Body.transform.localRotation, q, Roteto);
    }
}
