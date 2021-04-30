﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    public Transform mainLight;
    public int rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = 60;
    }

    // Update is called once per frame
    void Update()
    {
        mainLight.Rotate(rotation * Time.deltaTime, 0, 0);
    }
}
