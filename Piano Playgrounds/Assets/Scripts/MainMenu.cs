using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     if((PlayerPrefs.GetString("currPiano"))==null){
        PlayerPrefs.SetString("currPiano", "standard");
     }
     else{
        Debug.Log("currPiano has already beene set");
     }
    }
   public void StartLearning(){
     SceneManager.LoadScene("#1 Ionian");
   }

   public void EnterThePlayground(){
      SceneManager.LoadScene("Piano Playground");
   }

  public void SelectPiano(){
      SceneManager.LoadScene("Piano Selection");
   }
    // Update is called once per frame
   // void Update()
   // {
        
   // }
}
