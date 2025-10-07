using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Выход из игры...");
        Application.Quit();
    }
}
