using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bobcamscript : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    // Start is called before the first frame update
    void Start()
    {
        //Cam1.SetActive(true);
        //Cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //bobcam();
    }
    public void bobcam()
    {
        Cam2.SetActive(true);
        Cam1.SetActive(false);
    }
}
