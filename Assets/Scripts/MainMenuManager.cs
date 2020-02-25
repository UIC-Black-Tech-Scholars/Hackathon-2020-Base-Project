using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainMain;
    public GameObject SettingsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSettingButtonClicked()
    {
        Debug.Log("You have pressed the button");
        MainMain.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
