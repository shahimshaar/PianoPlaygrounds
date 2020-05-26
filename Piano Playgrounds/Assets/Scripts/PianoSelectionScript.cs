using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PianoSelectionScript : MonoBehaviour
{
    // Start is called before the first frame update

    //public void Start(){
    //    PlayerPrefs.SetString("currPiano", "piano");
   // }
    public void setPiano()
    {
        PlayerPrefs.SetString("currPiano", "piano");
    }

    public void setXylophone()
    {
        PlayerPrefs.SetString("currPiano", "xylophone");
    }

    public void setSynth()
    {
        PlayerPrefs.SetString("currPiano", "synth");
    }

    public void goBack(){
        SceneManager.LoadScene("Main Menu");
    }
}
