using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ParticleSystem Touch;

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

            if (Touch != null)
            {
                Instantiate(Touch, transform.position, Quaternion.identity);
            }


            Destroy(gameObject); // ����������: gameObject, � �� GameObject
        }
    }
}