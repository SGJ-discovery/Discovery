using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlasingText : MonoBehaviour {

    //テキストの点滅

    Text StartText;


    bool Flasing = false;



	// Use this for initialization
	void Start () {

        StartText = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Flasing == false)
        {
            StartText.enabled = true;
            Flasing = true;
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
        Flasing = false;
    }

   



}
