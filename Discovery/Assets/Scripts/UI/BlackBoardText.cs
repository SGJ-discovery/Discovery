using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBoardText : MonoBehaviour
{
    enum AllItems
    {
        pencil,
        eraser,
        dictionary,
        locker,
        curtain,
        green,
        nanika,
        hati,
        kyu
    }

    private List<string> AllItemsText = new List<string>();

    public TextMesh[] Text = new TextMesh[3];

    private GameObject Kyoutaku;

    // Use this for initialization
    void Start ()
    {
        AllItemsText.Add("pencil");
        AllItemsText.Add("eraser");
        AllItemsText.Add("dictionary");
        AllItemsText.Add("locker");
        AllItemsText.Add("curtain");
        AllItemsText.Add("green");
        AllItemsText.Add("nanika");
        AllItemsText.Add("hati");
        AllItemsText.Add("kyu");

        GameObject ObjPen = GameObject.Find("pencil");
        GameObject ObjLock = GameObject.Find("eraser");
        GameObject ObjCur = GameObject.Find("dictionary");

        Kyoutaku = GameObject.FindWithTag("Kyoutaku");

        GameObject[] ObjList = { ObjPen, ObjLock, ObjCur };

        SetBBText(ObjList);
    }

	// Update is called once per frame
	void Update ()
    {
        if(Kyoutaku == null)
        {
            Kyoutaku = GameObject.FindWithTag("Kyoutaku");
        }
    }

    public void SetBBText(GameObject[] AnswerItems)
    {
        for(int i = 0; i < 3; i++)
        {
            switch (GetIndex(AnswerItems[i]))
            {
                case (int)AllItems.pencil: Text[i].text = AllItemsText[(int)AllItems.pencil]; break;
                case (int)AllItems.eraser: Text[i].text = AllItemsText[(int)AllItems.eraser]; break;
                case (int)AllItems.dictionary: Text[i].text = AllItemsText[(int)AllItems.dictionary]; break;
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
        Debug.Log("objname : " + Obj);
        for(int i = 0; i < 3; i++)
        {
            if (Text[i].text.Equals(ItemText)) index = i;
        }
        if (Obj.name.Equals(ItemText + "(Clone)"))
        {
            RemoveBBText(index);
            Destroy(Obj.gameObject);
            Kyoutaku.SendMessage(ItemText);
        }
    }

    private int GetIndex(GameObject Obj)
    {
        int ret;
        ret = AllItemsText.IndexOf(Obj.name);
        return ret;
    }
}
