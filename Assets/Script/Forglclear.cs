using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class Forglclear : MonoBehaviour
{
    private GameObject Camera;
 

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.FindWithTag("MainCamera");

    }

    // Update is called once per frame
    void Update()
    {
        if ((bool)Variables.Object(Camera).Get("RectOn"))
        {
            GL.Clear(true, true, Color.black);
        }

    }

}
