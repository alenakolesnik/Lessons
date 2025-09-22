using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float bounceForce = 500f; // сила прыжка

    private void OnCollisionEnter(Collision collision)
    {
        // проверяем, что столкновение произошло с игроком
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // сбрасываем скорость вниз (чтобы всегда прыгал одинаково)
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);

                // подбрасываем игрока вверх
                rb.AddForce(Vector3.up * bounceForce);
                Debug.Log("Bounce! Игрок подпрыгнул 🚀");
            }
        }
    }
}