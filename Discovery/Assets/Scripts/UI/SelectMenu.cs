using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour {

    private GameObject Obj;
    private GameObject Panel;

    [SerializeField]
    private BlackBoardText BBText;
    [SerializeField]
    private Text[] Text = new Text[3];

	// Use this for initialization
	void Start () {
        Panel = GameObject.Find("SelectMenu");
        Panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("p"))
        {
            GameObject obj = GameObject.Find("pencil");
            SetItem(obj);
        }
	}

    public void SetItem(GameObject Item)
    {
        Obj = Item;

        for(int i = 0; i < 3; i++)
        {
            Text[i].text = BBText.Text[i].text;
            if(BBText.Text[i].gameObject.activeSelf)
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
