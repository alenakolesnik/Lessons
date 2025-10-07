using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 1f;
    public float JumpForce = 1f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Движение
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * Speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // Прыжок БЕЗ проверки земли
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}