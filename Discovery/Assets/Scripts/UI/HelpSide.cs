using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpSide : MonoBehaviour {



    public GameObject HelpPage;


    // Use this for initialization
    void Start () {

        HelpPage.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Open()
    {

        HelpPage.SetActive(true);

    }

    void Close()
    {


        HelpPage.SetActive(false);
    }
}
