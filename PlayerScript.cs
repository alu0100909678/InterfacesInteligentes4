﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public int poder = 0;

    // Use this for initialization
    void Start () {
        GameController.AumentoPoder += AumentarPoder;
        GameController.ReduccionPoder += ReducirPoder;
    }

    private void AumentarPoder()
    {
        poder++;
        Debug.Log(poder);
    }

    private void ReducirPoder()
    {
        poder--;
        Debug.Log(poder);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
