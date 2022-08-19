using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess = 6;
    private int minValue = 1;
    private int maxValue = 10;

    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("is it higher or lower than " + guess + "?");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("is it higher or lower then " + guess + "?");
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("yay ^_^!! i guessed correct!!!");
            Debug.Log("");
            StartGame();
        }
    }
    void StartGame()
    {
        guess = 5;
        minValue = 1;
        maxValue = 10;

        Debug.Log("welcome to our number guessing game :3");
        Debug.Log("the number range is from "+ minValue + " and " + maxValue);
        Debug.Log("guess a number between the given range");
        Debug.Log("is your number higher or lower than " + guess + "?");
        Debug.Log("push up arrow = higher, push down = lower, push enter = correct");
        maxValue = maxValue + 1;
    }
}
