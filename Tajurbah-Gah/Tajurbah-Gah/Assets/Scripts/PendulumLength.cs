using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PendulumLength : MonoBehaviour
{
    public Text Lengthtext;
    public GameObject bob;
    public GameObject ropeParent;
    private Vector3 initialScale;
    public int pendulumlength;
    private void OnEnable()
    {
        initialScale = bob.transform.localScale;
       // Debug.Log("INitial scale: " + initialScale);
    }
    public void ChangePendulumLength(float scale)
    {
        Debug.Log("Scale of bob " + bob.transform.lossyScale);
        ChangeRopeLength(scale);

        ResetBobScale();
    }

    public void ChangeRopeLength(float scale)
    {
        ropeParent.transform.localScale = new Vector3(1, scale, 1);
    }

    public void ResetBobScale()
    {
        bob.transform.localScale = initialScale;
    }

    public void setlength(int length)
    {
        
        pendulumlength = length;
        Lengthtext.text = length.ToString();
    }
    public int getlength()
    {
        return pendulumlength;
    }
}
