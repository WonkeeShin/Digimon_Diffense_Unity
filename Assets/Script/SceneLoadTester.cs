using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class SceneLoadTester : MonoBehaviour
{
    private GameObject Next_Scene;
    public bool MapOkBool;
    public string Number_Level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        Next_Scene = GameObject.Find("Next_Scene_button");
        MapOkBool = (bool)Variables.Object(Next_Scene).Get("Map_Go_Ok_Bool");
        Number_Level = (string)Variables.Object(Next_Scene).Get("Determined_Stage_Name");
    }

    void OnMouseDown()
    {
        MapOkBool = (bool)Variables.Object(Next_Scene).Get("Map_Go_Ok_Bool");
        Number_Level = (string)Variables.Object(Next_Scene).Get("Determined_Stage_Name");
        if (MapOkBool)
        {
            SceneLoader.Instance.LoadScene("Map"+Number_Level);
        }
        
  
        
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
