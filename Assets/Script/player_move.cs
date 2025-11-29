using UnityEngine;
using UnityEngine.InputSystem;

public class player_move : MonoBehaviour
{
    [SerializeField] GameObject Body;
    [SerializeField] float Speed;
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
    }
}
