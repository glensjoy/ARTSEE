﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
           // Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.Log("HIT");

        }

    }

    void CheckColor()
    {
       
    }
}
