using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine;

public class aboutscript : MonoBehaviour
{
    public Button back;
    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(delegate {wayback(); });
    }

    void wayback(){
         SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
