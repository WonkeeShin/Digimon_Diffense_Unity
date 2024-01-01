using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

public class GameStartButton : MonoBehaviour
{
    private GameObject Next_Scene;
    public bool MapOkBool;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        Next_Scene = GameObject.Find("Game_Start_button");
        MapOkBool = (bool)Variables.Object(Next_Scene).Get("Map_Go_Ok_Bool");
    }

    void OnMouseDown()
    {
        MapOkBool = (bool)Variables.Object(Next_Scene).Get("Map_Go_Ok_Bool");
        if (MapOkBool)
        {
            SceneLoader.Instance.LoadScene("Map_Select_Menu");
        }



    }


    // Update is called once per frame
    void Update()
    {

    }
}
