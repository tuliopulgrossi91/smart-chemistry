using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Text text_Quest_0, text_Quest_1, text_Quest_2; // texts info questions
    public Text text_Select_0, text_Select_1, text_Select_2; // texts buttons select
    public Text text_Score, text_Record;
    private int count_Quest; // counter number of questions
    private int q; // question list
    public static bool finish; // check finish game
    public static int r; // random number select
    public int score, record; // score and record game

    void Start()
    {
        count_Quest = 1;
        CheckRandom();
        finish = false;
        text_Quest_2.text = "" + count_Quest.ToString() + "/10";
    }

    void Update()
    {
        switch (Levels.x)
        {
            case 0: // Level 0
                text_Quest_0.text = "Numbers";
                break;
            case 1: // Level 1
                text_Quest_0.text = "Symbols";
                break;
            case 2: // Level 2
                text_Quest_0.text = "Names";
                break;
            case 3: // Level 3
                text_Quest_0.text = "Atomic Mass";
                break;
            case 4: // Level 4
                text_Quest_0.text = "Period";
                break;
            case 5: // Level 5
                text_Quest_0.text = "Family";
                break;
        }

        if (q < 10)
        {
            QuestList();
            CheckRandom();
        }
    }

    public void Select(int s)
    {
        switch (s)
        {
            case 0: // Button Select 0
                switch (Levels.x)
                {
                    case 0: // Level 0
                        if (text_Select_0.text == List.numbers_right[q])
                        {
                            score++;
                        }
                        break;
                    case 1: // Level 1
                        if (text_Select_0.text == List.symbols_right[q])
                        {
                            score++;
                        }
                        break;
                    case 2: // Level 2
                        if (text_Select_0.text == List.names_right[q])
                        {
                            score++;
                        }
                        break;
                    case 3: // Level 3
                        if (text_Select_0.text == List.mass_right[q])
                        {
                            score++;
                        }
                        break;
                    case 4: // Level 4
                        if (text_Select_0.text == List.period_right[q].ToString())
                        {
                            score++;
                        }
                        break;
                    case 5: // Level 5
                        if (text_Select_0.text == List.family_right[q])
                        {
                            score++;
                        }
                        break;
                }
                NextQuest();
                break;
            case 1: // Button Select 1
                switch (Levels.x)
                {
                    case 0: // Level 0
                        if (text_Select_1.text == List.numbers_right[q])
                        {
                            score++;
                        }
                        break;
                    case 1: // Level 1
                        if (text_Select_1.text == List.symbols_right[q])
                        {
                            score++;
                        }
                        break;
                    case 2: // Level 2
                        if (text_Select_1.text == List.names_right[q])
                        {
                            score++;
                        }
                        break;
                    case 3: // Level 3
                        if (text_Select_1.text == List.mass_right[q])
                        {
                            score++;
                        }
                        break;
                    case 4: // Level 4
                        if (text_Select_1.text == List.period_right[q].ToString())
                        {
                            score++;
                        }
                        break;
                    case 5: // Level 5
                        if (text_Select_1.text == List.family_right[q])
                        {
                            score++;
                        }
                        break;
                }
                NextQuest();
                break;
            case 2: // Button Select 2
                switch (Levels.x)
                {
                    case 0: // Level 0
                        if (text_Select_2.text == List.numbers_right[q])
                        {
                            score++;
                        }
                        break;
                    case 1: // Level 1
                        if (text_Select_2.text == List.symbols_right[q])
                        {
                            score++;
                        }
                        break;
                    case 2: // Level 2
                        if (text_Select_2.text == List.names_right[q])
                        {
                            score++;
                        }
                        break;
                    case 3: // Level 3
                        if (text_Select_2.text == List.mass_right[q])
                        {
                            score++;
                        }
                        break;
                    case 4: // Level 4
                        if (text_Select_2.text == List.period_right[q].ToString())
                        {
                            score++;
                        }
                        break;
                    case 5: // Level 5
                        if (text_Select_2.text == List.family_right[q])
                        {
                            score++;
                        }
                        break;
                }
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

            if (score > record)
            {
                record = score;
                PlayerPrefs.SetInt("Record", record);
            }

            PlayerPrefs.GetInt("Record", record);

            text_Score.text = "Score:  " + score;
            text_Record.text = "Record: " + PlayerPrefs.GetInt("Record", record);
        }
        else
        {
            QuestList();
            CheckRandom();
        }
        if (q < 10)
        {
            q++;
        }
    }

    void QuestList()
    {
        // Check Button Level Names
        switch (Levels.x)
        {
            case 0: // Level 0
                text_Quest_1.text = "" + List.numbers[q];
                break;
            case 1: // Level 1
                text_Quest_1.text = "" + List.symbols[q];
                break;
            case 2: // Level 2
                text_Quest_1.text = "" + List.names[q];
                break;
            case 3: // Level 3
                text_Quest_1.text = "" + List.mass[q];
                break;
            case 4: // Level 4
                text_Quest_1.text = "" + List.period[q];
                break;
            case 5: // Level 5
                text_Quest_1.text = "" + List.family[q];
                break;
        }
    }

    void CheckRandom()
    {
        r = Random.Range(0, 3);

        if (r == 0)
        {
            // result = alt 1

            switch (Levels.x)
            {
                case 0: // Level 0
                    text_Select_0.text = "" + List.numbers_right[q];
                    text_Select_1.text = "" + List.numbers_alt1[q];
                    text_Select_2.text = "" + List.numbers_alt2[q];
                    break;
                case 1: // Level 1
                    text_Select_0.text = "" + List.symbols_right[q];
                    text_Select_1.text = "" + List.symbols_alt1[q];
                    text_Select_2.text = "" + List.symbols_alt2[q];
                    break;
                case 2: // Level 2
                    text_Select_0.text = "" + List.names_right[q];
                    text_Select_1.text = "" + List.names_alt1[q];
                    text_Select_2.text = "" + List.names_alt2[q];
                    break;
                case 3: // Level 3
                    text_Select_0.text = "" + List.mass_right[q];
                    text_Select_1.text = "" + List.mass_alt1[q];
                    text_Select_2.text = "" + List.mass_alt2[q];
                    break;
                case 4: // Level 4
                    text_Select_0.text = "" + List.period_right[q];
                    text_Select_1.text = "" + List.period_alt1[q];
                    text_Select_2.text = "" + List.period_alt2[q];
                    break;
                case 5: // Level 5
                    text_Select_0.text = "" + List.family_right[q];
                    text_Select_1.text = "" + List.family_alt1[q];
                    text_Select_2.text = "" + List.family_alt2[q];
                    break;
            }
        }
        if (r == 1)
        {
            // result = alt 2

            switch (Levels.x)
            {
                case 0: // Level 0
                    text_Select_0.text = "" + List.numbers_alt1[q];
                    text_Select_1.text = "" + List.numbers_right[q];
                    text_Select_2.text = "" + List.numbers_alt2[q];
                    break;
                case 1: // Level 1
                    text_Select_0.text = "" + List.symbols_alt1[q];
                    text_Select_1.text = "" + List.symbols_right[q];
                    text_Select_2.text = "" + List.symbols_alt2[q];
                    break;
                case 2: // Level 2
                    text_Select_0.text = "" + List.names_alt1[q];
                    text_Select_1.text = "" + List.names_right[q];
                    text_Select_2.text = "" + List.names_alt2[q];
                    break;
                case 3: // Level 3
                    text_Select_0.text = "" + List.mass_alt1[q];
                    text_Select_1.text = "" + List.mass_right[q];
                    text_Select_2.text = "" + List.mass_alt2[q];
                    break;
                case 4: // Level 4
                    text_Select_0.text = "" + List.period_alt1[q];
                    text_Select_1.text = "" + List.period_right[q];
                    text_Select_2.text = "" + List.period_alt2[q];
                    break;
                case 5: // Level 5
                    text_Select_0.text = "" + List.family_alt1[q];
                    text_Select_1.text = "" + List.family_right[q];
                    text_Select_2.text = "" + List.family_alt2[q];
                    break;
            }
        }
        if (r == 2)
        {
            // result = alt 3

            switch (Levels.x)
            {
                case 0: // Level 0
                    text_Select_0.text = "" + List.numbers_alt1[q];
                    text_Select_1.text = "" + List.numbers_alt2[q];
                    text_Select_2.text = "" + List.numbers_right[q];
                    break;
                case 1: // Level 1
                    text_Select_0.text = "" + List.symbols_alt1[q];
                    text_Select_1.text = "" + List.symbols_alt2[q];
                    text_Select_2.text = "" + List.symbols_right[q];
                    break;
                case 2: // Level 2
                    text_Select_0.text = "" + List.names_alt1[q];
                    text_Select_1.text = "" + List.names_alt2[q];
                    text_Select_2.text = "" + List.names_right[q];
                    break;
                case 3: // Level 3
                    text_Select_0.text = "" + List.mass_alt1[q];
                    text_Select_1.text = "" + List.mass_alt2[q];
                    text_Select_2.text = "" + List.mass_right[q];
                    break;
                case 4: // Level 4
                    text_Select_0.text = "" + List.period_alt1[q];
                    text_Select_1.text = "" + List.period_alt2[q];
                    text_Select_2.text = "" + List.period_right[q];
                    break;
                case 5: // Level 5
                    text_Select_0.text = "" + List.family_alt1[q];
                    text_Select_1.text = "" + List.family_alt2[q];
                    text_Select_2.text = "" + List.family_right[q];
                    break;
            }
        }
    }
}