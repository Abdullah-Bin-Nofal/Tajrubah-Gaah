using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfActiveObject : MonoBehaviour
{
    [SerializeField]
    public GameObject[] uICanvases;
    [SerializeField]
    public GameObject[] images;

    [SerializeField]
    public GameObject WelcomePanel;

    [SerializeField]
    public float waitTime;


    // Start is called before the first frame update

    private void Start()
    {
        for (int i = 0; i < uICanvases.Length; i++)
        {
            uICanvases[i].SetActive(false);
        }
        for (int i = 0; i < images.Length; i++)
        {
            images[i].GetComponent<Image>().enabled = false;
        }
        this.gameObject.GetComponent<Animator>().enabled = true;
        //StartCoroutine(WaitForTime());
        


    }
    public void  Waiting()
    {
        //yield return new WaitForSeconds(waitTime);
        for (int i = 0; i < uICanvases.Length; i++)
        {
            uICanvases[i].SetActive(true);
        }
        for (int i = 0; i < images.Length; i++)
        {
            images[i].GetComponent<Image>().enabled = true;
        }

        if (PlayerPrefs.GetString("WelcomeScreen") == "Yes")
        {
            WelcomePanel.SetActive(true);
        }
        else if (PlayerPrefs.GetString("WelcomeScreen") == "No")
        {
            WelcomePanel.SetActive(false);
        }
        this.gameObject.GetComponent<Animator>().enabled = false;
        PlayerPrefs.SetString("WelcomeScreen", "No");
    }
}

