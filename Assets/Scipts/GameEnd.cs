using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text numberText;

    public MagicNumbers magicNumbers;

    void Start()
    {
        magicNumbers = FindObjectOfType<MagicNumbers>();
        int number = magicNumbers.guess;
        numberText.text = number.ToString();

        Destroy(magicNumbers.gameObject);
    }
}
