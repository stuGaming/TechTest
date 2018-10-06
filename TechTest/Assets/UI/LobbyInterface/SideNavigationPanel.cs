using UnityEngine;
using System.Collections;

public class SideNavigationPanel : BaseUI
{
    public GameObject OpenGamesButton;
    public GameObject CloseGamesButton;
    public GameObject OpenUsersButton;
    public GameObject CloseUsersButton;

    private void setButtons(int scenario)
    {
        switch (scenario)
        {
            case 0:
                //Base scenario no tabs open
                OpenGamesButton.SetActive(true);
                CloseGamesButton.SetActive(false);
                OpenUsersButton.SetActive(true);
                CloseUsersButton.SetActive(false);
                break;
            case 1:
                //game scenario game tabs open
                OpenGamesButton.SetActive(false);
                CloseGamesButton.SetActive(true);
                OpenUsersButton.SetActive(true);
                CloseUsersButton.SetActive(false);
                break;
            case 2:
                //users scenario user tabs open
                OpenGamesButton.SetActive(true);
                CloseGamesButton.SetActive(false);
                OpenUsersButton.SetActive(false);
                CloseUsersButton.SetActive(true);
                break;
            
        }
    }



    public void OpenGameTab()
    {
        setButtons(1);
        Mediator.SendMessage(UiEvents.OpenGamePanel);
    }

    public void OpenUserTab()
    {
        setButtons(2);

        Mediator.SendMessage(UiEvents.OpenUserPanel);
    }
    public void CloseGameTab()
    {
        setButtons(0);

        Mediator.SendMessage(UiEvents.HideGamePanel);
    }

    public void CloseUserTab()
    {
        setButtons(0);

        Mediator.SendMessage(UiEvents.HideUserPanel);
    }
}
