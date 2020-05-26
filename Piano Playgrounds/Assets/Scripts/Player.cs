using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
     public Button C, CS, D,DS, E, F, FS, G,GS, A, AS, B, C2;

    // Start is called before the first frame update
    void Start()
    {

                    Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Vector3 vectorToTarget = mouse - transform.position;
                    float angle = (Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg) - 90;
                    Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                    transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 2000000);
                    Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
                    Vector3 myPos = new Vector3(transform.position.x, transform.position.y + .203f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
