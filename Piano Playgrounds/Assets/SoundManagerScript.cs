using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip C, D, E, F, G, A, B;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        C = Resources.Load<AudioClip> ("xylophone-c");
        D = Resources.Load<AudioClip> ("xylophone-d");
        E = Resources.Load<AudioClip> ("xylophone-e1");
        F = Resources.Load<AudioClip> ("xylophone-f");
        G = Resources.Load<AudioClip> ("xylophone-g");
        A = Resources.Load<AudioClip> ("xylophone-a");
	B = Resources.Load<AudioClip> ("xylophone-b");


        audioSrc = GetComponent<AudioSource> ();
    }


    public static void PlayC(){
	audioSrc.PlayOneShot(C);
	}
public static void PlayD(){
	audioSrc.PlayOneShot(D);
	}
public static void PlayE(){
	audioSrc.PlayOneShot(E);
	}
public static void PlayF(){
	audioSrc.PlayOneShot(F);
	}
public static void PlayG(){
	audioSrc.PlayOneShot(G);
	}
public static void PlayA(){
	audioSrc.PlayOneShot(A);
	}
public static void PlayB(){
	audioSrc.PlayOneShot(B);
	}

    // Update is called once per frame
    void Update()
    {
        
    }


   // public static void PlaySound (string clip)
   // {
   //     switch (clip) {
   //     case "Attack":
   //         audioSrc.PlayOneShot (Attack);
   //         break;
   //     case "Battery":
   //         audioSrc.PlayOneShot (Battery);
   //         break;
    //    case "Critical":
     //       audioSrc.PlayOneShot (Critical);
     //       break;
     //   case "NewGame":
     //       audioSrc.PlayOneShot (NewGame);
     //       break;
     //   case "Death":
      //      audioSrc.PlayOneShot (Death);
      //      break;
     //   }
   // }

}
