using UnityEngine;
using System.Collections;

public class AuthController : MonoBehaviour
{
    public GameObject splashPanel;
    public GameObject welcomePanel;
    public GameObject loginPanel;
    public GameObject registerPanel;

    public float splashDuration = 3f;

    void Start()
    {
        StartCoroutine(SplashSequence());
    }


    IEnumerator SplashSequence()
    {
        // Pastikan kondisi awal
        splashPanel.SetActive(true);
        welcomePanel.SetActive(false);
        loginPanel.SetActive(false);
        registerPanel.SetActive(false);


        // Tunggu beberapa detik
        yield return new WaitForSeconds(splashDuration);


        // Pindah panel
        splashPanel.SetActive(false);
        welcomePanel.SetActive(true);
        loginPanel.SetActive(false);
        registerPanel.SetActive(false);
    }

    public void ShowLogin()
    {
        splashPanel.SetActive(false);
        welcomePanel.SetActive(false);
        loginPanel.SetActive(true);
        registerPanel.SetActive(false);
    }

    public void ShowRegister()
    {
        splashPanel.SetActive(false);
        welcomePanel.SetActive(false);
        loginPanel.SetActive(false);
        registerPanel.SetActive(true);
    }
}
