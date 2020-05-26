using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class IonianSoundManager : MonoBehaviour
 {
     //Make sure to attach these Buttons in the Inspector
     public Button C, D, E, F, G, A, B, C2;
    public  AudioClip theOne;
       public AudioSource audioSrc;
       public string currentPiano;
       public string nextNote;
       public int counter;
       public string[] notes = {"C","D","E","F","G","A","B","C2"};
       public bool unlock;
        public GameObject player;



     void Start()
        {
        //PlayerPrefs.SetString("currPiano", "standard");
         unlock = false;
         counter = 0;

         currentPiano = PlayerPrefs.GetString("currPiano");
         C.onClick.AddListener(delegate {PlaySound("C"); });
         D.onClick.AddListener(delegate {PlaySound("D"); });
         E.onClick.AddListener(delegate {PlaySound("E"); });
         F.onClick.AddListener(delegate {PlaySound("F"); });
         G.onClick.AddListener(delegate {PlaySound("G"); });
         A.onClick.AddListener(delegate {PlaySound("A"); });
         B.onClick.AddListener(delegate {PlaySound("B"); });
         C2.onClick.AddListener(delegate {PlaySound("C2"); });
         audioSrc = GetComponent<AudioSource> ();
         }

     void Update()
     {
        if(currentPiano != PlayerPrefs.GetString("currPiano")){
                 currentPiano = PlayerPrefs.GetString("currPiano");}
        else {
            Debug.Log("gucci");}
     }



     void PlaySound(string note){
          if(unlock==true){
                  theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
                  audioSrc.PlayOneShot(theOne);
          }
          else if(note=="C2" && nextNote=="C2"){
            unlock = true;
            theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
            audioSrc.PlayOneShot(theOne);
          }
          else{
          nextNote = notes[counter];
          if(note==null)
            Debug.Log("null val");
          else if(note!=nextNote)
            Debug.Log("note locked");
          else{
                theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
                audioSrc.PlayOneShot(theOne);
                counter++;
          }
          }
     }

 }


