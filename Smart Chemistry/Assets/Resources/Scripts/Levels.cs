using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public GameObject Questions, Pause, Settings, Results;
    public static string btn_name;

    // questions game
    public void QuestionsGame(bool q)
    {
        Questions.SetActive(true);
    }

    // settings game
    public void SettingsGame(bool s)
    {
        Settings.SetActive(s);
    }

    // get name of button
    public void CheckButton(Text t)
    {
        btn_name = t.text;
    }

    // pause game
    public void OnApplicationPause(bool pause)
    {
        Pause.SetActive(pause);
    }

    // back menu
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        // game finish - show results
        if (Quest.finish == true)
        {
            Results.SetActive(true);
        }
    }
}