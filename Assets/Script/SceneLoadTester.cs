using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class SceneLoadTester : MonoBehaviour
{
    private GameObject Next_Scene;
    public bool MapOkBool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        Next_Scene = GameObject.Find("Next_Scene_button");
        MapOkBool = (bool)Variables.Object(Next_Scene).Get("Map_Go_Ok_Bool");
    }

    void OnMouseDown()
    {
        MapOkBool = (bool)Variables.Object(Next_Scene).Get("Map_Go_Ok_Bool");
        if (MapOkBool)
        {
            SceneLoader.Instance.LoadScene("Map_00");
        }
        
  
        
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
