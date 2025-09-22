using UnityEngine;

public class Collectible : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
      if (other.TryGetComponent<PlayerController> (out var player))
        {
            Destroy(gameObject);
        }
    } 
}
