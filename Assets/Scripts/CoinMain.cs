﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<CoinGet1>().AddPoint(10);
            Destroy(this.gameObject);
        }
    }
}
