using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Genius.");
            Debug.Log("The answer is " + guess);
            StartGame();
        }
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to NumberWizard");
        Debug.Log("please guess a number between " + min + " and " + max);
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        PrintQuestion();
    }

    void PrintQuestion()
    {
        Debug.Log("tell me if your number higher or lower than " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Enter = Correct");
    }
}