using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Controller : MonoBehaviour
{
    public delegate void FuntionsList();
 
    public GameObject mainTarget; //target object of the code is for
    List<Function_> sequence; //list of functions (type Functions_). The code sequence is read from here
    private int isPlaying;
 
 
 
    MainLoop loop1;
 
    public void Play()
    {
        sequence.Clear();
     
 
        sequence = TranslateCodeFromBlocks(transform.parent, sequence);
 
        foreach (var sequence in sequence)
        {
            Debug.Log(sequence);
        }
 
        isPlaying = 2;
        loop1 = new MainLoop(mainTarget, sequence);
        StartCoroutine(loop1.Play());
 
 
 
    }
 
    public void Stop()
    {
        StopCoroutine(loop1.Play());
    }
 
    void Start()
    {
        isPlaying = 0;
        sequence = new List<Function_>();
    }
 
    void Update()
    {
          if (isPlaying == 2) //play
          {
 
              if (loop1.end == true)
              {
                  StopCoroutine(loop1.Play());
              }
          }
          if (isPlaying == 1) //stop
          {
              StopCoroutine(loop1.Play());
 
          }
    }
 
    //recursive parser function
    private List<Function_> TranslateCodeFromBlocks(Transform parent, List<Function_> sequence_)
    {
        foreach (Transform child in parent)
        {
           
            var functionName = child.name.Split('_'); //looks like a little face ^^
 
            string function1 = functionName[0];
            if (function1 == "Function") // Not executed
            {
                string function = functionName[1];
 
             
                switch (function)
                {
 
                    case "MoveRight":
                        sequence_.Add(new MoveRight("MoveRight"));
                        break;
                    case "MoveLeft":
                        sequence_.Add(new MoveLeft("MoveLeft"));
                        break;
                    case "MoveUp":
                        sequence_.Add(new MoveUp("MoveUp"));
                        break;
                    case "MoveDown":
                        sequence_.Add(new MoveDown("MoveDown"));
                        break;
 
                }
            }
        }
 
        return sequence_;
    }
 
}