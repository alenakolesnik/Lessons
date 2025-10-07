using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public int CurrentScore = 0;

    void Update()
    {
        // Каждый кадр обновляем текст на экране
        ScoreText.text = "Очки: " + CurrentScore;
    }
}