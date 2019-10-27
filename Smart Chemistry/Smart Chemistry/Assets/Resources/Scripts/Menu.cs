using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuManager, Settings, Credits, Exit;

    // menu game
    public void MenuGame(bool m) => MenuManager.SetActive(m);

    // settings game
    public void SettingsGame(bool s) => Settings.SetActive(s);

    // credits game
    public void CreditsGame(bool c) => Credits.SetActive(c);

    // exit game
    public void ExitGame(bool c) => Exit.SetActive(c);

    // confirm exit game
    public void ConfirmExitGame() => Application.Quit();

    // load level
    public void LoadLevel() => SceneManager.LoadScene(1);
}