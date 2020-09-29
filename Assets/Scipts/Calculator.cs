using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public Text titleText;
    public Text resultText;
    public Text gameOver;
    public int sum;

    int result;
    int step;
    
    private void Start()
    {
        titleText.text = "Наберите" + 50 + "очков за минимальное количество ходов";
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            result += 1;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            result += 2;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            result += 3;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            result += 4;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            result += 5;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            result += 6;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            result += 7;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            result += 8;
            UpdateResult();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            result += 9;
            UpdateResult();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            result = 0;
            step = 0;
            gameOver.text = " ";
            resultText.text = "Сумма: " + result;
        }
        if (result == sum)
        {
            gameOver.text = "Игра окончена ! Количество ходов: " + step; ;
            Start();
        }
    }

    private void UpdateResult()
    {

        if (result <= sum)
        {
            resultText.text = "Сумма: " + result;
            step++;
        }
        if (result > sum)
        {
            resultText.text = "Вы превысили значение";
        }
    }
}
