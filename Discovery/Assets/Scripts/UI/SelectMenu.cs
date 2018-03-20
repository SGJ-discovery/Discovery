using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour {

    private static GameObject Obj;
    private static GameObject Panel;

    //[SerializeField]
    private static BlackBoardText BBText;
    //[SerializeField]
    private static Text[] Text = new Text[3];

	// Use this for initialization
	void Start () {
        BBText = GameObject.Find("block_board").GetComponent<BlackBoardText>();
        Panel = GameObject.Find("SelectMenu");

        Text[0] = GameObject.Find("Text (1)").GetComponent<Text>();
        Text[1] = GameObject.Find("Text (2)").GetComponent<Text>();
        Text[2] = GameObject.Find("Text (3)").GetComponent<Text>();

        Panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        //if (Input.GetKeyDown("p"))
        //{
        //    GameObject obj = GameObject.Find("pencil");
        //    SetItem(obj);
        //}
        //if (Input.GetKeyDown("o"))
        //{
        //    GameObject obj = GameObject.Find("curtain");
        //    SetItem(obj);
        //}
        if(BBText == null)
        {
            BBText = GameObject.Find("block_board").GetComponent<BlackBoardText>();
        }
    }

    public void SetItem(GameObject Item)
    {
        Obj = Item;

        for (int i = 0; i < 3; i++)
        {
            Text[i].text = BBText.Text[i].text;
            if (BBText.Text[i].gameObject.activeSelf)
            {
                Text[i].gameObject.SetActive(true);
            }
            else
            {
                Text[i].gameObject.SetActive(false);
            }
        }

        Panel.gameObject.SetActive(true);
    }

    public void CloseMenu(string ItemText)
    {
        Panel.gameObject.SetActive(false);
        BBText.CheckItem(Obj, ItemText);
    }
}
