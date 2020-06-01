using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

 public class IonianSoundManager : MonoBehaviour
 {
     public Button C, D, E, F, G, A, B, C2, nextOne, back;
     public  AudioClip theOne;
     public AudioSource audioSrc;
     public string currentPiano;
     public string nextNote;
     public int counter;
     public string[] notes = {"C","D","E","F","G","A","B","C2"};
     public bool unlock;
     public GameObject player,currButton;
        // public GameObject idleanimation, jumpanimation;
        //public Vector3 newlocation;



     void Start()
        {
        //PlayerPrefs.SetString("currPiano", "standard");
         player = GameObject.FindWithTag("Player");
         unlock = false;
         counter = 0;
         nextNote = notes[counter];

         currentPiano = PlayerPrefs.GetString("currPiano");
         back.onClick.AddListener(delegate {goback(); });
         C.onClick.AddListener(delegate {PlaySound("C"); });
         D.onClick.AddListener(delegate {PlaySound("D"); });
         E.onClick.AddListener(delegate {PlaySound("E"); });
         F.onClick.AddListener(delegate {PlaySound("F"); });
         G.onClick.AddListener(delegate {PlaySound("G"); });
         A.onClick.AddListener(delegate {PlaySound("A"); });
         B.onClick.AddListener(delegate {PlaySound("B"); });
         C2.onClick.AddListener(delegate {PlaySound("C2"); });
         nextOne.onClick.AddListener(delegate {nextScale();});
         audioSrc = GetComponent<AudioSource> ();
         }

     void Update()
     {
        if(currentPiano != PlayerPrefs.GetString("currPiano")){
                 currentPiano = PlayerPrefs.GetString("currPiano");}
        else {
            Debug.Log("All is well.");}
     }

     void goback(){
        SceneManager.LoadScene("Main Menu");
     }
     void nextScale(){
        SceneManager.LoadScene("D Major");
     }



     void PlaySound(string note){
        //currButton = GameObject.FindWithTag(note);
        //newlocation = currButton.transform.position;
          currButton = GameObject.Find(note);
          player.transform.position = currButton.transform.position;
          if(unlock==true){
                  theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
                  audioSrc.PlayOneShot(theOne);
          }
          else if(note=="C2" && nextNote=="C2"){
            unlock = true;
            counter = 0;
            theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
            audioSrc.PlayOneShot(theOne);
            nextOne.interactable = true;
          }
          else{
          if(note==null)
            Debug.Log("null val");
          else if(note!=nextNote)
            Debug.Log("note locked");
          else{
                    nextNote = notes[counter+1];

                theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
                audioSrc.PlayOneShot(theOne);
                counter++;
          }
          }
     }

 }


