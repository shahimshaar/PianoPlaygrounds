using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PianoSelectionScript : MonoBehaviour
{
    // Start is called before the first frame update

    //public void Start(){
    //    PlayerPrefs.SetString("currPiano", "standard");
   // }
    public void setStandard()
    {
        PlayerPrefs.SetString("currPiano", "standard");
    }

    public void setXylophone()
    {
        PlayerPrefs.SetString("currPiano", "xylophone");
    }

    public void goBack(){
        SceneManager.LoadScene("Main Menu");
    }
}
