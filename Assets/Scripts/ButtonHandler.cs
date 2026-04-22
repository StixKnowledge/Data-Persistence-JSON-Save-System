using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameUI;

    public System.Action OnNewGame;
    public static ButtonHandler instance;

    GameObject onMainMenu;
    TextMeshProUGUI deathText;
    TextMeshProUGUI coinText;

    Color deathColor;
    Color coinColor;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    void Start()
    {
        deathText = gameUI.transform.Find("Death").GetComponent<TextMeshProUGUI>();
        coinText = gameUI.transform.Find("Coins").GetComponent<TextMeshProUGUI>();
        onMainMenu = gameUI.transform.Find("MainMenu").gameObject;

        deathColor = deathText.color;
        coinColor = coinText.color;
        EnableTransparent();

    }

    public void OnNewGameClicked()
    {
        DisableTransparent();
        OnNewGame?.Invoke();
        mainMenu.SetActive(false);
    }
    public void OnLoadGame()
    {
        DisableTransparent();
        mainMenu.SetActive(false);
    }
    public void OnMainMenu()
    {
        EnableTransparent();
        mainMenu.SetActive(true);
    }
    public void EnableTransparent()
    {
        onMainMenu.SetActive(false);
        deathColor.a = 0f; // Set alpha between 0 (invisible) and 1 (fully visible)
        coinColor.a = 0f; // Set alpha between 0 (invisible) and 1 (fully visible)
        deathText.color = deathColor;
        coinText.color = coinColor;
    }
    public void DisableTransparent()
    {
        onMainMenu.SetActive(true);
        deathColor.a = 1f; // Set alpha between 0 (invisible) and 1 (fully visible)
        coinColor.a = 1f; // Set alpha between 0 (invisible) and 1 (fully visible)

        deathText.color = deathColor;
        coinText.color = coinColor;
    }
}
