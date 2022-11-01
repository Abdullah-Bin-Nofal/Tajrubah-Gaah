using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkipScript : MonoBehaviour
{
    public int count;
    public int checkcount;
    public GameObject Skipbutton;
    // Start is called before the first frame update
    void Start()
    {
        count = PlayerPrefs.GetInt("Practical_ID");
    }

    // Update is called once per frame
    void Update()
    {
        if (checkcount <= count)
        {
            Skipbutton.SetActive(true);
        }
    }
    public void skippressed()
    {
        PlayerPrefs.SetString("WelcomeScreen", "Yes");
    }
    public void notskipped()
    {
        PlayerPrefs.SetString("WelcomeScreen", "No");
    }
}
