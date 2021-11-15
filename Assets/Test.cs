using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private int j = 5;

    private void Start()
    {
        print(j);
        Add5(ref j);
        print(j);
    }

    private void Add5(ref int a)
    {
        a += 5;
    }

}
