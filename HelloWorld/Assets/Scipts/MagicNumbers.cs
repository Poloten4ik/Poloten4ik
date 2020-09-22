using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    public int min ;
    public int max ;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        //min = 1;
        //max = 1000;

        print("Загадайте число от " + min + " до " + max);
        UpdateGuess();
    }

    // Update is called once per frame
    void Update()
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
            print("Игра закончена");
            Start();

        }
    }
    void UpdateGuess()
    {
        guess = (min + max) / 2;
        print("Ваше число: " + guess + " ?");
    }
}
