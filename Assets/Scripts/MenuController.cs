using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
����// ���� ����� ����� ������� ����� OnClick Events
����public void StartGame()
    {
        SceneManager.LoadScene("pro"); // SampleScene - ��� �������� ����� �����, ������� ���������
����}
}