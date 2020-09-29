﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    public Text title;
    public Text guessText;
    public Text resultText;
    public Text gameOver;

    public int min ;
    public int max ;
    
    int guess;
    int result;

    private void Start()
    {
        min = 1;
        max = 1000;
        title.text = "Загадайте цифру от " + min + " до " + max;
        title.color = Color.red;
        UpdateGuess();       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            max = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return ) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            gameOver.text = "game over";
            resultText.text = "Количество ходов: " + (result - 1);
            resultText.color = Color.black;
            Start();

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            min = 1;
            max = 1000;
            guess = (min + max) / 2;
            result = 0;
            gameOver.text = " ";
            resultText.text = " ";
            Start();
        }
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        guessText.text = "Ваше число: " + guess + " ? ";
        guessText.color = Color.blue;
        result += 1;
    }
}