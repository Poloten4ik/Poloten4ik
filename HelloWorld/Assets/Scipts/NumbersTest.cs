using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersTest : MonoBehaviour
{
    int number;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }

    // update is called once per frame
    void update()
    {
        number += 1;
        print(number);

    }
}
