using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
  
    public void LoadScene()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadTutorial1()
    {
        SceneManager.LoadScene("Tutorial_1");
    }
    public void LoadTutorial2()
    {
        SceneManager.LoadScene("Tutorial_2");
    }
    public void LoadTutorial3()
    {
        SceneManager.LoadScene("Tutorial_3");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadPractical1()
    {
        SceneManager.LoadScene("Practical_1");
    }
    public void LoadPractical2()
    {
        SceneManager.LoadScene("Practical_2");
    }
    public void LoadPractical3()
    {
        SceneManager.LoadScene("Practical_3");
    }

}
