using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OpenTV()
    {
        SceneManager.LoadScene("TV");
    }

    public void OpenUI()
    {
        SceneManager.LoadScene("UI_scene");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
