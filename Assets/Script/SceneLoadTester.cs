﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoadTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        SceneLoader.Instance.LoadScene("SampleScene");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
