using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Scene Names (exact!)")]
    [SerializeField] private string sceneTV = "TV";
    [SerializeField] private string sceneUI = "UI_scene";
    [SerializeField] private string sceneRUN = "RUN";
    [SerializeField] private string sceneMenu = "MainMenu";

    public void OpenTV() => Load(sceneTV);
    public void OpenUI() => Load(sceneUI);
    public void OpenRUN() => Load(sceneRUN);
    public void BackToMenu() => Load(sceneMenu);

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    private void Load(string sceneName)
    {
        if (string.IsNullOrWhiteSpace(sceneName)) return;
        SceneManager.LoadScene(sceneName);
    }
}