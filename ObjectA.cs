using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectA : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        GameController.AumentarPoder();
    }

	public void cambiarTam () {
		transform.localScale += new Vector3(0.5F, 0.5F, 0.5F);
	}
}
