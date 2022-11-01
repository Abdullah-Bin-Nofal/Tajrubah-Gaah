using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BobSwitch : MonoBehaviour
{
    public Text Masstext;
    public GameObject Ironbob;
    public int bobmass = 0;

    private Rigidbody rb;

    [Header("Textures")]
    public Texture[] bobTextures;
    public void SwitchBobTexture(int index)
    {
        Debug.Log("Iron");
        Ironbob.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", bobTextures[index]);
        if(index == 0)
        {
            rb.mass = 50f;

        }
        else if (index == 1){
            rb.mass = 40f;

        }
        else if (index == 2)
        {
            rb.mass = 30f;

        }
        else if (index == 3)
        {
            rb.mass = 20f;

        }

    }
    void Start()
    {
        rb = Ironbob.GetComponent<Rigidbody>();
       // setmass(0);
    }

    public void setmass(int mass)
    {
        bobmass = mass;
        Masstext.text = mass.ToString();
    }
   
}
