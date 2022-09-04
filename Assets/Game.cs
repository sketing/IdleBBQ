using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.meows += GameManager.multiplier;
        PlayerPrefs.SetInt("meows", GameManager.meows);
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.meows >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.meows -= 25;
            PlayerPrefs.SetInt("meows", GameManager.meows);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.meows >= 250)
        {
            GameManager.multiplier += 10;
            GameManager.meows -= 250;
            PlayerPrefs.SetInt("meows", GameManager.meows);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.meows >= 2500)
        {
            GameManager.multiplier += 100;
            GameManager.meows -= 2500;
            PlayerPrefs.SetInt("meows", GameManager.meows);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    private void Update()
    {
        ui.text = "Meows: " + GameManager.meows;
    }
}
