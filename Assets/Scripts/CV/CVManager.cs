using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CVManager : MonoBehaviour
{
    public static CVManager instance;

    public Image image;

    private const string KEY_PAPER = "Paper";
    private const string KEY_SCISSORS = "Scissors";
    private const string KEY_STONE = "Stone";

    private void Awake()
    {
        instance = this;
    }

    public void PushMessage(string msg)
    {
        var key = msg.Trim().Split('=')[1];

        Color color;
        switch (key)
        {
            case KEY_PAPER:
                color = Color.yellow;
                break;
            case KEY_SCISSORS:
                color = Color.green;
                break;
            case KEY_STONE:
                color = Color.red;
                break;
            default:
                color = Color.white;
                break;
        }
        image.color = color;
        Debug.Log(image.color);
    }
}
