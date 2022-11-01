using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tajurbah_Gah
{
    public class ReadingsScript : MonoBehaviour
    {
        // Start is called before the first frame update

        public Text AmplitudeSimple, MassSimple, LengthSimple, TimeSimple;
        public List<Text> Amplitude, Mass, Length, Time, Oscillations, TimePeriod;
        public int count;
        public GameObject Tablefull;
        public bool readings;
        public GameObject Checktab, calculator,TabsPanel;
        public StopwatchController st;
        public float mytime;
        public int totaloscillations;
        public OscillationsScript Oscilat;
        void Start()
        {


            // Mass.text = "0.0";
        }

        // Update is called once per frame
        void Update()
        {
            // amplitude = Amp.GetComponent<SimpleHarmonicMotion>().getamplitude();
            // bobmass = Bmass.GetComponent<BobSwitch>().getmass();


        }
        public void yessave()
        {
            readings = true;
          
        }
        public void checksave()
        {
            readings = false;
        }
        public void savereadings()
        {


            if (count >= 0 && count < 5)
            {
                if (readings)
                {
                    Amplitude[count].text = AmplitudeSimple.text;
                    Mass[count].text = MassSimple.text;
                    Length[count].text = LengthSimple.text;
                    Time[count].text = TimeSimple.text;

                    totaloscillations = Oscilat.setoscillations();
                    Oscillations[count].text = totaloscillations.ToString();
                    if (totaloscillations > 0)
                    {
                        mytime = st.setmytime() / totaloscillations;
                        TimePeriod[count].text = mytime.ToString("f2") + "s";
                    }
                    else
                    {
                        TimePeriod[count].text = "Can't Divide by 0";
                    }
                    
                    count++;

                    calculator.SetActive(true);
                   
                    readings = false;
                    //Debug.LogError("Count: " + count);
                }
                else
                {
                    TabsPanel.SetActive(true);
                    Checktab.SetActive(true);
                    
                }
            }


            else if (count >= 5)
            {
                Tablefull.SetActive(true);
                //Debug.Log("Table is full");
            }


        }
        public void ClearTable()
        {

            for (int i = 0; i < Amplitude.Count; i++)
            {
                Amplitude[i].text = "";
                Mass[i].text = "";
                Length[i].text = "";
                Time[i].text = "";
                Oscillations[i].text = "";
                TimePeriod[i].text = "";
            }
            count = 0;
            //Tablefull.SetActive(false);
        }
      
        
    }
}