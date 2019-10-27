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
    public int score_0, score_1, score_2, score_3, score_4, score_5, record_0, record_1, record_2, record_3, record_4, record_5; // score and record game 

    void Start()
    {
        record_0 = PlayerPrefs.GetInt("Record0");
        record_1 = PlayerPrefs.GetInt("Record1");
        record_2 = PlayerPrefs.GetInt("Record2");
        record_3 = PlayerPrefs.GetInt("Record3");
        record_4 = PlayerPrefs.GetInt("Record4");
        record_5 = PlayerPrefs.GetInt("Record5");

        count_Quest = 0;
        QuestList();
        CheckRandom();
        finish = false;
        text_Quest_2.text = "" + count_Quest.ToString() + "/9";
    }

    void Update()
    {
        switch (Levels.x)
        {
            case 0: // Level 0
                text_Quest_0.text = "Números";
                break;
            case 1: // Level 1
                text_Quest_0.text = "Símbolos";
                break;
            case 2: // Level 2
                text_Quest_0.text = "Nomes";
                break;
            case 3: // Level 3
                text_Quest_0.text = "Massa Atômica";
                break;
            case 4: // Level 4
                text_Quest_0.text = "Período";
                break;
            case 5: // Level 5
                text_Quest_0.text = "Família";
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
                            score_0++;
                        }
                        break;
                    case 1: // Level 1
                        if (text_Select_0.text == List.symbols_right[q])
                        {
                            score_1++;
                        }
                        break;
                    case 2: // Level 2
                        if (text_Select_0.text == List.names_right[q])
                        {
                            score_2++;
                        }
                        break;
                    case 3: // Level 3
                        if (text_Select_0.text == List.mass_right[q])
                        {
                            score_3++;
                        }
                        break;
                    case 4: // Level 4
                        if (text_Select_0.text == List.period_right[q].ToString())
                        {
                            score_4++;
                        }
                        break;
                    case 5: // Level 5
                        if (text_Select_0.text == List.family_right[q])
                        {
                            score_5++;
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
                            score_0++;
                        }
                        break;
                    case 1: // Level 1
                        if (text_Select_1.text == List.symbols_right[q])
                        {
                            score_1++;
                        }
                        break;
                    case 2: // Level 2
                        if (text_Select_1.text == List.names_right[q])
                        {
                            score_2++;
                        }
                        break;
                    case 3: // Level 3
                        if (text_Select_1.text == List.mass_right[q])
                        {
                            score_3++;
                        }
                        break;
                    case 4: // Level 4
                        if (text_Select_1.text == List.period_right[q].ToString())
                        {
                            score_4++;
                        }
                        break;
                    case 5: // Level 5
                        if (text_Select_1.text == List.family_right[q])
                        {
                            score_5++;
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
                            score_0++;
                        }
                        break;
                    case 1: // Level 1
                        if (text_Select_2.text == List.symbols_right[q])
                        {
                            score_1++;
                        }
                        break;
                    case 2: // Level 2
                        if (text_Select_2.text == List.names_right[q])
                        {
                            score_2++;
                        }
                        break;
                    case 3: // Level 3
                        if (text_Select_2.text == List.mass_right[q])
                        {
                            score_3++;
                        }
                        break;
                    case 4: // Level 4
                        if (text_Select_2.text == List.period_right[q].ToString())
                        {
                            score_4++;
                        }
                        break;
                    case 5: // Level 5
                        if (text_Select_2.text == List.family_right[q])
                        {
                            score_5++;
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
        text_Quest_2.text = "" + count_Quest.ToString() + "/9";

        if (count_Quest > 9)
        {
            finish = true;

            if (Levels.x == 0)
            {
                if (score_0 > record_0)
                {
                    record_0 = score_0;
                    PlayerPrefs.SetInt("Record0", record_0);
                }

                text_Score.text = "Pontos:  " + score_0;
                text_Record.text = "Totais: " + PlayerPrefs.GetInt("Record0");
            }

            if (Levels.x == 1)
            {
                if (score_1 > record_1)
                {
                    record_1 = score_1;
                    PlayerPrefs.SetInt("Record1", record_1);
                }

                text_Score.text = "Pontos:  " + score_1;
                text_Record.text = "Totais: " + PlayerPrefs.GetInt("Record1");
            }

            if (Levels.x == 2)
            {
                if (score_2 > record_2)
                {
                    record_2 = score_2;
                    PlayerPrefs.SetInt("Record2", record_2);
                }

                text_Score.text = "Pontos:  " + score_2;
                text_Record.text = "Totais: " + PlayerPrefs.GetInt("Record2");
            }

            if (Levels.x == 3)
            {
                if (score_3 > record_3)
                {
                    record_3 = score_3;
                    PlayerPrefs.SetInt("Record3", record_3);
                }

                text_Score.text = "Pontos:  " + score_3;
                text_Record.text = "Totais: " + PlayerPrefs.GetInt("Record3");
            }

            if (Levels.x == 4)
            {
                if (score_4 > record_4)
                {
                    record_4 = score_4;
                    PlayerPrefs.SetInt("Record4", record_4);
                }

                text_Score.text = "Pontos:  " + score_4;
                text_Record.text = "Totais: " + PlayerPrefs.GetInt("Record4");
            }

            if (Levels.x == 5)
            {
                if (score_5 > record_5)
                {
                    record_5 = score_5;
                    PlayerPrefs.SetInt("Record5", record_5);
                }

                text_Score.text = "Pontos:  " + score_5;
                text_Record.text = "Totais: " + PlayerPrefs.GetInt("Record5");
            }
        }
        else
        {
            if (q < 10)
            {
                q++;
            }

            QuestList();
            CheckRandom();
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