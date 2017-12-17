using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kyoutaku : MonoBehaviour {


    public GameObject Pen;
    public GameObject Era;
    public GameObject Dic;
   

	// Use this for initialization
	void Start () {

        Pen.SetActive(false);
        Era.SetActive(false);
        Dic.SetActive(false);
        
	}
	
	// Update is called once per frame
	void Update () {
		

        
	}


    void pencil()
    {

        Pen.SetActive(true);

    }

    void eraser()
    {

        Era.SetActive(true);

    }

    void dictionary()
    {

        Dic.SetActive(true);

    }
}
