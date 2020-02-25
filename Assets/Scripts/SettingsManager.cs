using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
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

    public void onBackButonClicked()
    {
        Debug.Log("You have pressed the button");
        MainMain.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void onDropDownChanged(Dropdown change)
    {
        Debug.Log("New Value : " + change.value);
        Debug.Log("New Value : " + change.name);

    }
}
