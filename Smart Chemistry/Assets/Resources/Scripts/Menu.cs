using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuManager, Settings, Credits;

    // menu game
    public void MenuGame(bool m)
    {
        MenuManager.SetActive(m);
    }

    // settings game
    public void SettingsGame(bool s)
    {
        Settings.SetActive(s);
    }

    // credits game
    public void CreditsGame(bool c)
    {
        Credits.SetActive(c);
    }

    // load level
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}