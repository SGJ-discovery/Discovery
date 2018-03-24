using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpControl : MonoBehaviour {


    public GameObject HelpPage;

    private bool OC;
    

	// Use this for initialization
	void Start () {

        HelpPage.SetActive(false);
        OC = false;
    }
	
	// Update is called once per frame
	void Update () {



        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("aaaaa");
            Help();
        }
	
	}

    void Help()
    {
        if (OC == false)
        {

            HelpPage.SetActive(true);
            OC = true;
        }
        else if (OC == true)
        {
            HelpPage.SetActive(false);
            OC = false;
        }
    }

    void Close()
    {

        if (OC == true)
        {
            HelpPage.SetActive(false);
            OC = false;
        }
    }


}
