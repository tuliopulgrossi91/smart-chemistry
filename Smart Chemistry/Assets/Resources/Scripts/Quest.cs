using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Text text_Quest_0, text_Quest_1, text_Quest_2;
    public Text text_Select_0, text_Select_1, text_Select_2;
    private int count_Quest = 1;
    public static bool finish;

    void Start()
    {
        finish = false;
        text_Quest_1.text = "Questão X";
        text_Quest_2.text = "" + count_Quest.ToString() + "/10";
    }

    public void Select(int s)
    {
        switch (s)
        {
            case 0: // Button Select 0
                NextQuest();
                break;
            case 1: // Button Select 1
                NextQuest();
                break;
            case 2: // Button Select 2
                NextQuest();
                break;
        }
    }

    void NextQuest()
    {
        count_Quest++;
        text_Quest_2.text = "" + count_Quest.ToString() + "/10";

        if (count_Quest > 10)
        {
            finish = true;
        }
    }

    void Update()
    {
        text_Quest_0.text = "" + Levels.btn_name;
    }
}