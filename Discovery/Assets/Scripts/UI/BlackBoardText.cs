using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBoardText : MonoBehaviour
{
    enum AllItems
    {
        pencil,
        eraser,
        chalk,
        locker,
        curtain,
        green,
        nanika,
        hati,
        kyu
    }

    private List<string> AllItemsText = new List<string>();

    public TextMesh[] Text = new TextMesh[3];

    // Use this for initialization
    void Start ()
    {
        AllItemsText.Add("pencil");
        AllItemsText.Add("eraser");
        AllItemsText.Add("chalk");
        AllItemsText.Add("locker");
        AllItemsText.Add("curtain");
        AllItemsText.Add("green");
        AllItemsText.Add("nanika");
        AllItemsText.Add("hati");
        AllItemsText.Add("kyu");

        //GameObject ObjPen = GameObject.Find("pencil");
        //GameObject ObjLock = GameObject.Find("locker");
        //GameObject ObjCur = GameObject.Find("curtain");

        //GameObject[] ObjList = { ObjPen, ObjLock, ObjCur };

        //SetBBText(ObjList);
    }

	// Update is called once per frame
	void Update ()
    {

    }

    public void SetBBText(GameObject[] AnswerItems)
    {
        for(int i = 0; i < 3; i++)
        {
            switch (GetIndex(AnswerItems[i]))
            {
                case (int)AllItems.pencil: Text[i].text = AllItemsText[(int)AllItems.pencil]; break;
                case (int)AllItems.eraser: Text[i].text = AllItemsText[(int)AllItems.eraser]; break;
                case (int)AllItems.chalk: Text[i].text = AllItemsText[(int)AllItems.chalk]; break;
                case (int)AllItems.locker: Text[i].text = AllItemsText[(int)AllItems.locker]; break;
                case (int)AllItems.curtain: Text[i].text = AllItemsText[(int)AllItems.curtain]; break;
                case (int)AllItems.green: Text[i].text = AllItemsText[(int)AllItems.green]; break;
                case (int)AllItems.nanika: Text[i].text = AllItemsText[(int)AllItems.nanika]; break;
                case (int)AllItems.hati: Text[i].text = AllItemsText[(int)AllItems.hati]; break;
                case (int)AllItems.kyu: Text[i].text = AllItemsText[(int)AllItems.kyu]; break;
            }
            Text[i].gameObject.SetActive(true);
        }
    }

    public void RemoveBBText(int ItemNum)
    {
        Text[ItemNum].gameObject.SetActive(false);
        Norma.iNormaCount++;
    }

    public void CheckItem(GameObject Obj, string ItemText)
    {
        int index = 0;
        for(int i = 0; i < 3; i++)
        {
            if (Text[i].text.Equals(ItemText)) index = i;
        }
        if (Obj.name.Equals(ItemText))
        {
            RemoveBBText(index);
        }
    }

    private int GetIndex(GameObject Obj)
    {
        int ret;
        ret = AllItemsText.IndexOf(Obj.name);
        return ret;
    }
}
