using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 1f;
    public float JumpForce = 1f;

    [HideInInspector]
    public bool canMove = true; // флаг управления

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        if (!canMove) return; // если управление заблокировано, выходим

        // ��������
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * Speed;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

        // ������ ��� �������� �����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}