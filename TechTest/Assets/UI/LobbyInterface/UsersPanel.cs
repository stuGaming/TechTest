using UnityEngine;
using System.Collections;

public class UsersPanel : BaseUI
{

    // Use this for initialization
    void Start()
    {
        Mediator.RegisterHandler(UiEvents.OpenUserPanel, this, OpenPanel);
        Mediator.RegisterHandler(UiEvents.HideUserPanel, this, ClosePanel);
        Mediator.RegisterHandler(UiEvents.OpenGamePanel, this, ClosePanel);
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
