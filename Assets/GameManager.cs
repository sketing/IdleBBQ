using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int money;
    public static int multi;
    // Start is called before the first frame update
    void Start()
    {
        multi = PlayerPrefs.GetInt("multi", 1);
        money = PlayerPrefs.GetInt("money", 0);
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
