﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    // Use this for initialization

    GameObject hpGage;

    void Start () {
        this.hpGage = GameObject.Find("hpGage");
    }
	
    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image> ().fillAmount -= 0.1f;
    }

	// Update is called once per frame
	void Update () {
	    	
	}
}
