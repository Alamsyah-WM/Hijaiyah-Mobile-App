using UnityEngine;
using System.Collections;
public class UIManagerController: MonoBehaviour
{
    public GameObject homePanel;
    public GameObject pelafalanPanel;

    void Start()
    {
        ShowPanel(homePanel);
    }

    public void ShowPanel(GameObject panel)
    {
        HideAllPanel();

        panel.SetActive(true);
    }

    void HideAllPanel()
    {
        homePanel.SetActive(false);
        pelafalanPanel.SetActive(false);
    }

    public void showHome()
    {
        ShowPanel(homePanel);
    }

    public void showPelafalan()
    {
        ShowPanel(pelafalanPanel);
    }
}
