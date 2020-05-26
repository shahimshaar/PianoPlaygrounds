using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class SoundManager : MonoBehaviour
 {
     //Make sure to attach these Buttons in the Inspector
     public Button C, CS, C2, C2S, D,DS,D2,D2S, E,E2, F,F2, FS,F2S, G,GS,G2,G2S, A, AS,A2,A2S, B, B2, C3;
     public  AudioClip theOne;
     public AudioSource audioSrc;
     public string currentPiano;



     void Start()
        {
        //PlayerPrefs.SetString("currPiano", "standard");
         currentPiano = PlayerPrefs.GetString("currPiano");
         C.onClick.AddListener(delegate {PlaySound("C"); });
         CS.onClick.AddListener(delegate {PlaySound("CS"); });
         C2.onClick.AddListener(delegate {PlaySound("C2"); });
         C2S.onClick.AddListener(delegate {PlaySound("C2S"); });
         D.onClick.AddListener(delegate {PlaySound("D"); });
         DS.onClick.AddListener(delegate {PlaySound("DS"); });
         D2.onClick.AddListener(delegate {PlaySound("D2"); });
         D2S.onClick.AddListener(delegate {PlaySound("D2S"); });
         E.onClick.AddListener(delegate {PlaySound("E"); });
         E2.onClick.AddListener(delegate {PlaySound("E2"); });
         F.onClick.AddListener(delegate {PlaySound("F"); });
         F2.onClick.AddListener(delegate {PlaySound("F2"); });
         FS.onClick.AddListener(delegate {PlaySound("FS"); });
         F2S.onClick.AddListener(delegate {PlaySound("F2S"); });
         G.onClick.AddListener(delegate {PlaySound("G"); });
         GS.onClick.AddListener(delegate {PlaySound("GS"); });
         G2.onClick.AddListener(delegate {PlaySound("G2"); });
         G2S.onClick.AddListener(delegate {PlaySound("G2S"); });
         A.onClick.AddListener(delegate {PlaySound("A"); });
         A2.onClick.AddListener(delegate {PlaySound("A2"); });
         AS.onClick.AddListener(delegate {PlaySound("AS"); });
         A2S.onClick.AddListener(delegate {PlaySound("A2S"); });
         B.onClick.AddListener(delegate {PlaySound("B"); });
         B2.onClick.AddListener(delegate {PlaySound("B2"); });
         C3.onClick.AddListener(delegate {PlaySound("C3"); });
         audioSrc = GetComponent<AudioSource> ();
         }

     void Update()
     {
        if(currentPiano != PlayerPrefs.GetString("currPiano")){
                 currentPiano = PlayerPrefs.GetString("currPiano");}
        else{
            Debug.Log("gucci");}
     }



     void PlaySound(string note){
          if(note==null)
            Debug.Log("null val");
          theOne = Resources.Load<AudioClip>(currentPiano+"-"+note);
          audioSrc.PlayOneShot(theOne);
     }

 }

 // To use this example, attach this script to an empty GameObject.
 // Create three buttons (Create>UI>Button). Next, select your
 // empty GameObject in the Hierarchy and click and drag each of your
 // Buttons from the Hierarchy to the Your First Button, Your Second Button
 // and Your Third Button fields in the Inspector.
 // Click each Button in Play Mode to output their message to the console.
 // Note that click means press down and then release.


