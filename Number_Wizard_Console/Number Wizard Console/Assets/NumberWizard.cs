using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start()
    {

        Debug.Log("HI! Welcome to the NUMBER WIZARD");
        Debug.Log("The WIZARD has the uncanny ability to READ NUMBERS from your mind!");
        Debug.Log("To start, think of a number between " + min + " and " + max);
        Debug.Log("=====================================================================");
        Debug.Log("Now, tell the NUMBER WIZARD if your number is higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = correct");
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So... the guess was too low? Let the WIZARD take another shot!");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("How about now? Is your number higher or lower than " + guess);
            //Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Oh? The guess was too high? Let the WIZARD take another crack at it!");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is the WIZARD getting closer? Is your number higher or lower than " + guess);
            //Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("THE WIZARD KNOWS ALL!");
        }
    }
}
