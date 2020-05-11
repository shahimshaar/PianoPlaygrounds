using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
   // void Start()
   // {
        
   // }
   public void StartLearning(){
     SceneManager.LoadScene("#1 Ionian");
   }

   public void EnterThePlayground(){
      SceneManager.LoadScene("Piano Playground");
   }

    // Update is called once per frame
   // void Update()
   // {
        
   // }
}
