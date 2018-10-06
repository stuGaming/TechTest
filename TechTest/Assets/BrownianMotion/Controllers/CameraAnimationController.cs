using UnityEngine;
using System.Collections;
using System;

public class CameraAnimationController : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        Mediator.RegisterHandler(UiEvents.OpenUserPanel,this,UserAnim);
        Mediator.RegisterHandler(UiEvents.HideUserPanel, this, StartAnim);
        Mediator.RegisterHandler(UiEvents.HideGamePanel, this, StartAnim);
        Mediator.RegisterHandler(UiEvents.OpenGamePanel, this, gameAnim);
    }

    private void ResetAllTriggers()
    {
        anim.ResetTrigger("GoToGame");
        anim.ResetTrigger("GoToStart");
        anim.ResetTrigger("GoToUser");

    }

    private void gameAnim(Message message)
    {
        ResetAllTriggers();
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("StayAtFriends")|| anim.GetCurrentAnimatorStateInfo(0).IsName("StartToFriends"))
        {
            anim.SetTrigger("GoToStart");
        }
        anim.SetTrigger("GoToGame");

    }

    private void StartAnim(Message message)
    {
        ResetAllTriggers();
        anim.SetTrigger("GoToStart");
    }

    private void UserAnim(Message message)
    {
        ResetAllTriggers();
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("StayAtGame")|| anim.GetCurrentAnimatorStateInfo(0).IsName("StartToGame"))
        {
            anim.SetTrigger("GoToStart");
        }
        anim.SetTrigger("GoToUser");
    }

    
}
