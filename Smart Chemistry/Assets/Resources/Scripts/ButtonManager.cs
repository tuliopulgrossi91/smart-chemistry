using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private Animator anima;

    void Start()
    {
        anima = GetComponent<Animator>();
        anima.enabled = true;
    }

    public void SetAnimator(int a)
    {
        if(a == 0)
        {
            anima.SetBool("anima", false);
        }
        else
        {
            anima.SetBool("anima", true);
        }
    }
}