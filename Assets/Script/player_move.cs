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
        var F = Body.transform.forward;
        var y = rb.linearVelocity.y;
        rb.linearVelocity = F * Inputvec.y;
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, y, rb.linearVelocity.z);

        //------  ------
        if (Inputvec.magnitude < 0.1f){
            return;
        }


        var angle = Mathf.Atan2(Inputvec.x, 0) * Mathf.Rad2Deg;
        var q = Quaternion.Euler(0, angle, 0);
        var Q = Body.transform.localRotation * q;
        Body.transform.localRotation = Quaternion.RotateTowards(Body.transform.localRotation, Q, Roteto);
    }

    void OnSpace(InputValue input)
    {

    }
}
