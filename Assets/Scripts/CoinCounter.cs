using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int totalCoins = 3; // ������� � ��� ������� �� �����

    private int collectedCoins = 0;

    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin()
    {
        collectedCoins++;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinText.text = $"������: {collectedCoins} / {totalCoins}";
    }
}