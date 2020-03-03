using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
{
    public GameObject MainMain;
    public GameObject SettingsMenu;

    public Image backgroundImage;

    private Color backgroundColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onApplyButtonClicked()
    {
        backgroundImage.color = backgroundColor;
        GameData gameData = new GameData(backgroundColor);
        SaveLoadManager.SaveFile(gameData);
    }

    public void onBackButonClicked()
    {
        Debug.Log("You have pressed the button");
        MainMain.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void onDropDownChanged(Dropdown change)
    {
        Debug.Log("New Value : " + change.value);
        if (change.value == 0)
        {//Change the background to red
            backgroundColor = Color.red;
        } else if (change.value == 1)
        {  // change to green
            backgroundColor = Color.green;
        } else
        { // chgange to blueColo
            backgroundColor = Color.blue;
        }
    }
}
