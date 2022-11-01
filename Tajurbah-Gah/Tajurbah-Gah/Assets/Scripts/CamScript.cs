using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cam()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
    }
}
