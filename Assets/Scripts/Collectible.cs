using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            // ��������� ������� � �������
            CoinCounter coinCounter = FindObjectOfType<CoinCounter>();
            if (coinCounter != null)
            {
                coinCounter.AddCoin();
            }

            Destroy(gameObject); // ����������: gameObject, � �� GameObject
        }
    }
}