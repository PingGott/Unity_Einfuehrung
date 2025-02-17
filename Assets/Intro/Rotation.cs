using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public int number;
    public float speed;
    public bool rrotation;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Die Start Nummer lautet {number}");
    }

    // Update is called once per frame
    void Update()
    {
        if (rrotation == true)
        {
            float rot = speed * Time.deltaTime;
            gameObject.transform.Rotate(rot, 4.0f, 3.0f);
        }
        else if (rrotation == false)
        {
            Debug.Log("Rotation is turned off");
        }
        
    }
}
