using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void toSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void Exitgame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
