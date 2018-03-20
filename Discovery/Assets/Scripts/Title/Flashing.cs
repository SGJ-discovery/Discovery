using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flasing : MonoBehaviour
{

    //テキストの点滅

    Text StartText;


    bool flasing = false;



    // Use this for initialization
    void Start()
    {

        StartText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        if (flasing == false)
        {
            StartText.enabled = true;
            flasing = true;
            Invoke("FlasingIN", 1.0f);
        }


    }



    void FlasingIN()
    {
        StartText.enabled = false;
        Invoke("FlasingOUT", 1.0f);
    }


    void FlasingOUT()
    {
        flasing = false;
    }





}
