using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.money += GameManager.multi;
        PlayerPrefs.SetInt("money", GameManager.money);
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.money >= 10)
        {
            GameManager.multi += 1;
            GameManager.money -= 10;
            PlayerPrefs.SetInt("money", GameManager.money);
            PlayerPrefs.SetInt("multi", GameManager.multi);
        }
        if (num == 2 && GameManager.money >= 90)
        {
            GameManager.multi += 10;
            GameManager.money -= 90; 
            PlayerPrefs.SetInt("money", GameManager.money);
            PlayerPrefs.SetInt("multi", GameManager.multi);
        }
        if (num == 3 && GameManager.money >= 800)
        {
            GameManager.multi += 100;
            GameManager.money -= 800;
            PlayerPrefs.SetInt("money", GameManager.money);
            PlayerPrefs.SetInt("multi", GameManager.multi);
        }
    }

    public void Update()
    {
        ui.text = "$: " + GameManager.money;
    }
}
