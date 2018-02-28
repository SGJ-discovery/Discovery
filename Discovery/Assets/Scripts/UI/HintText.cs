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

    static int HintNum = 0;

    private string[,] Text = new string[,] { { "字を書くものだよ", "字を消すものだよ", "単語を調べるものだよ" },
                                             { "野菜とかを切るものだよ", "ご飯をよそうものだよ", "料理で煮込むのに使うものだよ" },
                                             { "遠くの人とお話が出来るよ", "時間を教えてくれるよ", "黒板に書いてあるものを消すものだよ" } };

    // Use this for initialization
    void Start () {
        HintText1.text = Text[0, 0];
        HintText2.text = Text[0, 1];
        HintText3.text = Text[0, 2];
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

    public void setHint()
    {
        HintNum++;
        HintText1.text = Text[HintNum, 0];
        HintText2.text = Text[HintNum, 1];
        HintText3.text = Text[HintNum, 2];
    }
}
