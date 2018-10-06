using UnityEngine;
using System.Collections;

public class BaseUI : MonoBehaviour
{
    public Animator anim;
   
    protected void Show()
    {
        if (anim == null)
        {
            this.gameObject.SetActive(true);
        }
        else
        {

        }
    }
    protected void Hide()
    {
        if (anim == null)
        {
            this.gameObject.SetActive(false);
        }
        else
        {

        }
    }
}
