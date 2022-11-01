using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleHarmonicMotion : MonoBehaviour
{
    
    public Text Amplitudetext;
    public Text Oscillations;
    public GameObject swingimage;
    public GameObject stopimage;
    public GameObject Readingsbutton;
    public OscillationsScript os;
    public int oscillations;
    public GameObject Startstopbutton;

    Vector3 _rotateUntil;
    float _currentSpeed = 1f;
    float _dir = 30f;

    float MaxAngleDeflection = -30.0f;
    float SpeedOfPendulum = 2.0f;

    public bool movePendulum = false;
    public bool pausegame = false;
   
    public int pendulumamplitude;
  

    void Start()
    {
        stopimage.SetActive(false);
        swingimage.SetActive(true);
        //setamplitude(10);
        _rotateUntil = transform.rotation.eulerAngles * -1; //sets the point of changing direction, i.e if I start at 30 degress, I change dir at -30 degrees.
    }
    public void amplitude(float deflection)
    {
        MaxAngleDeflection = deflection;
    }
    public void speed(float pspeed)
    {
        SpeedOfPendulum = pspeed;
    }

    public void showreadingsbutton()
    {
        if (oscillations > 0)
        {
            Readingsbutton.SetActive(true);
            os.oscillationwarning();
            Startstopbutton.SetActive(false);
        }
    }

   

    void FixedUpdate()
    {
        oscillations = os.setoscillations();
        if(movePendulum && !pausegame )
        {
            stopimage.SetActive(true);
            swingimage.SetActive(false);
            Swing();
        }
        else
        {
            stopimage.SetActive(false);
            swingimage.SetActive(true);
          
            StopSwing();
        }
    }// just to be on the safe side we are going to neglect the air frition here. Also the speed can only be change by considering the leng

    public void MovePendulum()
    {
        movePendulum = !movePendulum;
      
    }
    public void gamepause()
    {
        pausegame = true;
    }
    public void gameunpause()
    {
        pausegame = false;
    }

    private void Swing()
    {
        float angle = MaxAngleDeflection * Mathf.Sin(Time.time * SpeedOfPendulum);
        transform.localRotation = Quaternion.Euler(angle, 0, 0);
       
       // Debug.LogError(angle);
        
    }
    private void StopSwing()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);

        
    }

    public void setamplitude( int amplitude)
    {
        pendulumamplitude = amplitude;
        Amplitudetext.text = amplitude.ToString();
    }

    public int getamplitude()
    {
        return pendulumamplitude;
    }

    
}
