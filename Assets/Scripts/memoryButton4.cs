﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoryButton4 : MonoBehaviour {
    public static bool stage1Button4 = false;
    public static bool stage2Button4 = false;
    public static bool stage3Button4 = false;
    public static bool stage4Button4 = false;
    private bool stop = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    private void OnMouseDown()
    {
        stop = false;
        if (chooseMemoryNum.roundNum == 1 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 4)
            {
                Debug.Log("worked");
                chooseMemoryNum.roundNum = 2;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage1Button4 = true;
            }
            else
            {
                Debug.Log("nope");
                memoryButton1.reset(4);
            }
        }
        else if (chooseMemoryNum.roundNum == 2 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1 && chooseMemoryNum.labelNum2[3] == 4)
            {
                chooseMemoryNum.roundNum = 3;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage2Button4 = true;
            }
            else if (chooseMemoryNum.displayNum == 1)
            {
                memoryButton1.reset(5);
            }
            if (chooseMemoryNum.displayNum == 2 && stage1Button4)
            {
                chooseMemoryNum.roundNum = 3;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage2Button4 = true;
            }
            else if (chooseMemoryNum.displayNum == 2)
            {
                memoryButton1.reset(6);
            }
            if (chooseMemoryNum.displayNum == 3)
            {
                Debug.Log("weird3");
                memoryButton1.reset(7);
            }
            if (chooseMemoryNum.displayNum == 4 && stage1Button4)
            {
                Debug.Log("worked2");
                chooseMemoryNum.roundNum = 3;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage2Button4 = true;
            }
            else if (chooseMemoryNum.displayNum == 4)
            {
                memoryButton1.reset(8);
            }
        }
        else if (chooseMemoryNum.roundNum == 3 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1)
            {
                if (memoryButton1.stage2Button1 && (chooseMemoryNum.labelNum2[0] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else if (memoryButton2.stage2Button2 && (chooseMemoryNum.labelNum2[1] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else if (memoryButton3.stage2Button3 && (chooseMemoryNum.labelNum2[2] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else if (memoryButton4.stage2Button4 && (chooseMemoryNum.labelNum2[3] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else
                {
                    memoryButton1.reset(9);
                }
            }
            if (chooseMemoryNum.displayNum == 2)
            {
                if (memoryButton1.stage1Button1 && (chooseMemoryNum.labelNum1[0] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else if (memoryButton2.stage1Button2 && (chooseMemoryNum.labelNum1[1] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else if (memoryButton3.stage1Button3 && (chooseMemoryNum.labelNum1[2] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else if (memoryButton4.stage1Button4 && (chooseMemoryNum.labelNum1[3] == chooseMemoryNum.labelNum3[3]))
                {
                    chooseMemoryNum.roundNum = 4;
                    memoryLabel1.labelPicked = false;
                    chooseMemoryNum.roundPicked = false;
                    stage3Button4 = true;
                }
                else
                {
                    memoryButton1.reset(10);
                }
            }
            if (chooseMemoryNum.displayNum == 3)
            {
                memoryButton1.reset(11);
            }
            if (chooseMemoryNum.displayNum == 4 && chooseMemoryNum.labelNum3[3] == 4)
            {
                chooseMemoryNum.roundNum = 4;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage3Button4 = true;
            }
            else if (chooseMemoryNum.displayNum == 4)
            {
                if(chooseMemoryNum.roundNum == 3 && !stop)
                {
                    memoryButton1.reset(12);
                }
            }
        }
        else if (chooseMemoryNum.roundNum == 4 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            if (chooseMemoryNum.displayNum == 1 && stage1Button4)
            {
                chooseMemoryNum.roundNum = 4;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage4Button4 = true;
            }
            else if (chooseMemoryNum.displayNum == 1)
            {
                memoryButton1.reset(13);
            }
            if (chooseMemoryNum.displayNum == 2)
            {
                memoryButton1.reset(14);
            }
            if ((chooseMemoryNum.displayNum == 3 || chooseMemoryNum.displayNum == 4) && stage2Button4)
            {
                chooseMemoryNum.roundNum = 4;
                memoryLabel1.labelPicked = false;
                chooseMemoryNum.roundPicked = false;
                stage4Button4 = true;
            }
            else if (chooseMemoryNum.displayNum == 3 || chooseMemoryNum.displayNum == 4)
            {
                memoryButton1.reset(15);
            }
        }
        else if (chooseMemoryNum.roundNum == 5 && !memoryModuleClear.clearMmemoryModule && !stop)
        {
            Debug.Log("5");
            if (chooseMemoryNum.displayNum == 1)
            {
                if (memoryButton1.stage1Button1 && (chooseMemoryNum.labelNum1[0] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage1Button2 && (chooseMemoryNum.labelNum1[1] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage1Button3 && (chooseMemoryNum.labelNum1[2] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage1Button4 && (chooseMemoryNum.labelNum1[3] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(16);
                }
            }
            if (chooseMemoryNum.displayNum == 2)
            {
                if (memoryButton1.stage2Button1 && (chooseMemoryNum.labelNum2[0] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage2Button2 && (chooseMemoryNum.labelNum2[1] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage2Button3 && (chooseMemoryNum.labelNum2[2] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage2Button4 && (chooseMemoryNum.labelNum2[3] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(17);
                }
            }
            if (chooseMemoryNum.displayNum == 3)
            {
                if (memoryButton1.stage4Button1 && (chooseMemoryNum.labelNum4[0] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage4Button2 && (chooseMemoryNum.labelNum4[1] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage4Button3 && (chooseMemoryNum.labelNum4[2] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage4Button4 && (chooseMemoryNum.labelNum4[3] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(18);
                }
            }
            if (chooseMemoryNum.displayNum == 4)
            {
                if (memoryButton1.stage3Button1 && (chooseMemoryNum.labelNum3[0] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton2.stage3Button2 && (chooseMemoryNum.labelNum3[1] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton3.stage3Button3 && (chooseMemoryNum.labelNum3[2] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else if (memoryButton4.stage3Button4 && (chooseMemoryNum.labelNum3[3] == chooseMemoryNum.labelNum5[3]))
                {
                    memoryModuleClear.clearMmemoryModule = true;
                }
                else
                {
                    memoryButton1.reset(19);
                }
            }
        }
    }
    private void OnMouseUp()
    {
        stop = true;
    }
}