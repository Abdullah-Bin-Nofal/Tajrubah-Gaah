using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSettingScript : MonoBehaviour
{
    public int Practical_ID;
    //public GameObject WelcomePanel;
    // Start is called before the first frame update
    void Start()
    {
        if (Practical_ID >= PlayerPrefs.GetInt("Practical_ID"))
        {
            PlayerPrefs.SetInt("Practical_ID", Practical_ID);
        }

        //if(PlayerPrefs.GetString("WelcomeScreen") == "Yes")
        //{
        //    WelcomePanel.SetActive(true);
        //}
        //else if (PlayerPrefs.GetString("WelcomeScreen") == "No")
        //{
        //    WelcomePanel.SetActive(false);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
