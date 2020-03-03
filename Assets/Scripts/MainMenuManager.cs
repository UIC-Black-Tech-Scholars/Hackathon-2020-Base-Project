using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainMain;
    public GameObject SettingsMenu;

    public Image backgroundImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        GameData gameData = SaveLoadManager.LoadFile();
        backgroundImage.color = new Color(
            gameData.color_r,
            gameData.color_g,
            gameData.color_b,
            gameData.color_a
            );
    }

    public void onSettingButtonClicked()
    {
        Debug.Log("You have pressed the button");
        MainMain.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
