﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class memoryLabel1 : MonoBehaviour {
    public static bool labelPicked = false;
    public Text text;
	// Use this for initialization
	void Start () {
        text.alignment = TextAnchor.MiddleCenter;
    }
	
	// Update is called once per frame
	void Update () {
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 1 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum1[0]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 2 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum2[0]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 3 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum3[0]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 4 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum4[0]);
        }
        if (!memoryLabel1.labelPicked && chooseMemoryNum.roundNum == 5 && chooseMemoryNum.listChosen)
        {
            text.text = ("" + chooseMemoryNum.labelNum5[0]);
        }
    }
}
