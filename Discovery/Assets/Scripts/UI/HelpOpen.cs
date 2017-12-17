using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpOpen : MonoBehaviour {

    GameObject Obj;

    [SerializeField]
    private HintText HT;

	// Use this for initialization
	void Start () {
        Obj = GameObject.Find("HelpObject");
        Obj.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HelpClick()
    {
        Obj.gameObject.SetActive(true);
        HT.setActive();
    }
}
