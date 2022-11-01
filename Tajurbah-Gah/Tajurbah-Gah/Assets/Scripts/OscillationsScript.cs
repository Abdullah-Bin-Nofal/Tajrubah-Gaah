using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OscillationsScript : MonoBehaviour
{
    public Text Oscillations;
    public int count = 0;
    public int oscilations = 0;
    public bool isoscilate = false;
    public GameObject warningbutton;
    public GameObject highoscillations;
    public GameObject lowoscillations;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void counting()
    {
        isoscilate = true;
    }
    public void notcounting()
    {
        isoscilate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle" && isoscilate)
        {
           
            count++;
            oscilations = count / 2;
            
        }
        Oscillations.text = oscilations.ToString();
        //oscillationwarning();
     
    }
    public void resetoscillations()
    {
        oscilations = count = 0;
        Oscillations.text = oscilations.ToString();
    }
    public int setoscillations()
    {
        return oscilations;
    }

    public void warningpressed()
    {
        if (oscilations > 0 && oscilations < 20 )
        {
            lowoscillations.SetActive(true);
        }
        else if (oscilations > 20)
            {
                highoscillations.SetActive(true);
            }
    }
    public void oscillationwarning()
    {
        if (oscilations > 0 && oscilations < 20 && !isoscilate)
        {
            warningbutton.SetActive(true);
        }
        if (oscilations > 20 && !isoscilate)
        {
            warningbutton.SetActive(true);
        }
    }
}
