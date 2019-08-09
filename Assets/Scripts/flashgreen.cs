﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace VRTK.Examples
{
    using UnityEngine;
    public class flashgreen : VRTK_InteractableObject
    {
        public bool isPressed = false;
        public List<Color> greenList;
        public GameObject myObject;
        public AudioClip soundEffect;
        public AudioSource source;
        private void Start()
        {
            source.clip = soundEffect;
        }
        public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
        {
            source.Play();
            base.StartUsing(currentUsingObject);
            //transform.Translate(0, 0, -Time.deltaTime);
            if (!myObject.GetComponent<SimonSaysModule>().round1)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1)
                {
                    myObject.GetComponent<SimonSaysModule>().round1 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round2)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 1 && myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().round2 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round3)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().round3 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round4)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && !myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().button3 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand4 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().round4 = true;
                }
                else
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = false;
                    myObject.GetComponent<SimonSaysModule>().button2 = false;
                    myObject.GetComponent<SimonSaysModule>().button3 = false;
                    myObject.GetComponent<SimonSaysModule>().button4 = false;
                    mistakes.mistakeNum += 1;
                }
            }
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            //transform.Translate(0, 0, Time.deltaTime);
        }
        public void flashG()
        {
            StartCoroutine(WaitG());
        }
        void OnMouseDown()
        {
            transform.Translate(0, 0, -Time.deltaTime);
            Debug.Log("clicked");
            if (!myObject.GetComponent<SimonSaysModule>().round1)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1)
                {
                    myObject.GetComponent<SimonSaysModule>().round1 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round2)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 1 && myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().round2 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round3)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().round3 = true;
                }
                else
                {
                    mistakes.mistakeNum += 1;
                }
            }
            else if (!myObject.GetComponent<SimonSaysModule>().round4)
            {
                if (myObject.GetComponent<SimonSaysModule>().rand == 1 && !myObject.GetComponent<SimonSaysModule>().button1)
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand2 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && !myObject.GetComponent<SimonSaysModule>().button2)
                {
                    myObject.GetComponent<SimonSaysModule>().button2 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand3 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && !myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().button3 = true;
                }
                else if (myObject.GetComponent<SimonSaysModule>().rand4 == 1 && myObject.GetComponent<SimonSaysModule>().button1 && myObject.GetComponent<SimonSaysModule>().button2 && myObject.GetComponent<SimonSaysModule>().button3)
                {
                    myObject.GetComponent<SimonSaysModule>().round4 = true;
                }
                else
                {
                    myObject.GetComponent<SimonSaysModule>().button1 = false;
                    myObject.GetComponent<SimonSaysModule>().button2 = false;
                    myObject.GetComponent<SimonSaysModule>().button3 = false;
                    myObject.GetComponent<SimonSaysModule>().button4 = false;
                    mistakes.mistakeNum += 1;
                }
            }
        }
        private void OnMouseUp()
        {
            transform.Translate(0, 0, Time.deltaTime);
        }
        IEnumerator WaitG()
        {
            Color z = greenList[0];
            GetComponent<MeshRenderer>().material.color = z;
            yield return new WaitForSeconds(1);
            Debug.Log("flashG");
            Color x = greenList[1];
            GetComponent<MeshRenderer>().material.color = x;
            yield return new WaitForSeconds(0.5f);
            GetComponent<MeshRenderer>().material.color = z;
            yield return new WaitForSeconds(1);
        }
    }
}
