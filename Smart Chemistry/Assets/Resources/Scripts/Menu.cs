using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private bool check;
    public GameObject Levels, Settings, Credits;

    public void Select(int s)
    {
        switch (s)
        {
            case 0: // levels 
                check = !check;
                Levels.SetActive(check);
                break;
            case 1: // settings
                check = !check;
                Settings.SetActive(check);
                break;
            case 2: // credits
                check = !check;
                Credits.SetActive(check);
                break;
            case 3: // load scene
                SceneManager.LoadScene(1);
                break;
        }
    }
}