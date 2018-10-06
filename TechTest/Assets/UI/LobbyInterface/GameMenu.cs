using UnityEngine;
using System.Collections;
using System;

public class GameMenu : BaseUI
{

    // Use this for initialization
    void Start()
    {
        Mediator.RegisterHandler(UiEvents.OpenGamePanel, this, OpenPanel);
        Mediator.RegisterHandler(UiEvents.HideGamePanel, this, ClosePanel);
        Mediator.RegisterHandler(UiEvents.OpenUserPanel, this, ClosePanel);
       
        Hide();
    }

    private void OpenPanel(Message message)
    {
        Show();
    }
    private void ClosePanel(Message message)
    {
        Hide();
    }


}
