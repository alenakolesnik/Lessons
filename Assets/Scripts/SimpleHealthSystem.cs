using UnityEngine;
using TMPro;

public class SimpleHealthSystem : MonoBehaviour
{
    public TextMeshProUGUI heartsText;
    public Transform respawnPoint;

    private int hearts = 3;
    private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
        UpdateHearts();
    }

    void Update()
    {
        if (player.transform.position.y < -2f)
        {
            LoseHeart();
        }
    }

    void LoseHeart()
    {
        hearts--;
        UpdateHearts();

        if (hearts > 0)
        {
            player.transform.position = respawnPoint.position;
        }
        else
        {
            Debug.Log("Game Over!");
        }
    }

    void UpdateHearts()
    {
        heartsText.text = "";
        for (int i = 0; i < hearts; i++)
        {
            heartsText.text += "♥️ ";
        }
    }
}