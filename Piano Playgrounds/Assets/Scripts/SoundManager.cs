using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class SoundManager : MonoBehaviour
 {
     //Make sure to attach these Buttons in the Inspector
     public Button C, CS, D,DS, E, F, FS, G,GS, A, AS, B, C2;
    public  AudioClip theOne;
       public AudioSource audioSrc;
       public string currentPiano;



     void Start()
        {
        //PlayerPrefs.SetString("currPiano", "xylophone");
        currentPiano = PlayerPrefs.GetString("currPiano");
         C.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"C"); });
         CS.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"CS"); });
         D.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"D"); });
         DS.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"DS"); });
         E.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"E"); });
         F.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"F"); });
         FS.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"FS"); });
         G.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"G"); });
         GS.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"GS"); });
         A.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"A"); });
         AS.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"AS"); });
         B.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"B"); });
         C2.onClick.AddListener(delegate {PlaySound(currentPiano+"-"+"C2"); });
         audioSrc = GetComponent<AudioSource> ();
         }

     void PlaySound(string note){
          if(note==null)
            Debug.Log("null val");
          theOne = Resources.Load<AudioClip>(note);
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


