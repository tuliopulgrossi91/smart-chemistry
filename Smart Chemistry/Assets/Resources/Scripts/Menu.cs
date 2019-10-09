using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Levels, Settings, Credits, Help;

    public void Select(int s)
    {
        switch (s)
        {
            case 0: // levels
                Levels.SetActive(true);
                break;
            case 1: // settings
                Settings.SetActive(true);
                break;
            case 2: // credits
                Credits.SetActive(true);
                break;
            case 3: // help
                Help.SetActive(true);
                break;
        }
    }
}