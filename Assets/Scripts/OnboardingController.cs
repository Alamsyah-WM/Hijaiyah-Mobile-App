using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class OnboardingController : MonoBehaviour
{
    [System.Serializable]
    public class OnboardingSlide
    {
        public string title;

        [TextArea(2,4)]
        public string description;
        public Sprite image;

    }

    [Header("Slides")]
    public OnboardingSlide[] slides;

    [Header("UI References")]
    public TMP_Text titleText;
    public TMP_Text descriptionText;
    public Image illustrationImage;

    [Header("Page Indicator")]
    public Image[] pageIndicators;
    public Color activeColor = Color.white;
    public Color inactiveColor = new Color(0.588f, 0.796f, 0.98f);

    [Header("Button")]
    public Button nextButton;
    public Button skipButton;
    public TMP_Text nextButtonText;

    [Header("Next Panel")]
    public GameObject onboardingPanel;
    public GameObject LoginPanel;

    private int currentPage = 0;

    private void Start()
    {
        currentPage = 0;
        ShowSlide();
    }

    public void NextSlide()
    {
        if (currentPage < slides.Length - 1)
        {
            currentPage++;
            ShowSlide();
        }
        else
        {
            FinishOnboarding();
        }
    }

    public void SkipOnboarding()
    {
        FinishOnboarding();
    }

    private void ShowSlide()
    {
        if (slides == null || slides.Length == 0) 
        return;

        titleText.text = slides[currentPage].title;
        descriptionText.text = slides[currentPage].description;
        illustrationImage.sprite = slides[currentPage].image;

        UpdatePageIndicator();

        if (currentPage == slides.Length - 1)
        {
            nextButtonText.text = "Mulai";
        } else
        {
            nextButtonText.text = "Lanjut";
        }
    }

    private void UpdatePageIndicator()
    {
        for (int i = 0; i < pageIndicators.Length; i++)
        {
            if (i == currentPage)
            {
                // Indicator aktif
                pageIndicators[i].color = activeColor;

                pageIndicators[i].transform.localScale =
                    new Vector3(1.3f, 1.3f, 1f);
            }
            else
            {
                // Indicator tidak aktif
                pageIndicators[i].color = inactiveColor;

                pageIndicators[i].transform.localScale =
                    Vector3.one;
            }
        }
    }

    private void FinishOnboarding()
    {
        onboardingPanel.SetActive(false);

        if(LoginPanel != null)
        {
            LoginPanel.SetActive(true);
        }
    }

}