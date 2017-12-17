using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextStage : MonoBehaviour
{
    [SerializeField]
    private Text Clear;
    [SerializeField]
    private Norma Norma;

	// Use this for initialization
	void Start ()
    {
        Clear.text = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Norma.iNormaCount >= 3)
        {
            Clear.text = "CLEAR STAGE";
            if (Input.GetKeyDown("space"))
            {
                Norma.iNormaCount = 0;
                Clear.text = "";
                Debug.Log("ステージをクリアしたから他の教室に行きたい");
            }
        }
    }
}
