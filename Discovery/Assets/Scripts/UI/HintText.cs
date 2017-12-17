using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintText : MonoBehaviour {

    [SerializeField]
    private BlackBoardText BBText;
    [SerializeField]
    private Text HintText1;
    [SerializeField]
    private Text HintText2;
    [SerializeField]
    private Text HintText3;

    // Use this for initialization
    void Start () {
        HintText1.text = "字を書くものだよ";
        HintText2.text = "字を消すものだよ";
        HintText3.text = "単語を調べるものだよ";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setActive()
    {
        HintText1.gameObject.SetActive(BBText.Text[0].gameObject.activeSelf);
        HintText2.gameObject.SetActive(BBText.Text[1].gameObject.activeSelf);
        HintText3.gameObject.SetActive(BBText.Text[2].gameObject.activeSelf);
    }

    public void setHint(string[] Hint)
    {
        HintText1.text = Hint[0];
        HintText2.text = Hint[1];
        HintText3.text = Hint[2];
    }
}
