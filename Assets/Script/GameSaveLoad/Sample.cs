using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        DataManager.Instance.LoadGameData();
    }

    // Update is called once per frame
    private void OnApplicationQuit()
    {
        DataManager.Instance.SaveGameData();
    }

}
