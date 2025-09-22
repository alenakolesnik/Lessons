using UnityEngine;

public class DeathZona : MonoBehaviour
{
    [Tooltip("Начальная точка возрождения игрока. Если не назначена, будет использоваться позиция (0,0,0)")]
    public Transform respawnPoint;

    private void Start()
    {
        if (respawnPoint == null)
        {
            GameObject defaultRespawn = new GameObject("DefaultRespawnPoint");
            respawnPoint = defaultRespawn.transform;
            respawnPoint.position = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RespawnPlayer(other.gameObject);
        }
    }

    private void RespawnPlayer(GameObject player)
    {
        CharacterController characterController = player.GetComponent<CharacterController>();
        bool wasEnabled = false;

        if (characterController != null)
        {
            wasEnabled = characterController.enabled;
            characterController.enabled = false;
        }

        // Телепортируем игрока на заданную точку
        player.transform.position = respawnPoint.position;
        player.transform.rotation = respawnPoint.rotation;

        // Сбрасываем скорость (если есть Rigidbody)
        Rigidbody rb = player.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;       // исправлено (linearVelocity → velocity)
            rb.angularVelocity = Vector3.zero;
        }

        if (characterController != null)
        {
            characterController.enabled = wasEnabled;
        }

        Debug.Log("Игрок возвращен на точку возрождения");
    }
}