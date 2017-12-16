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
        white,
        black,
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
        AllItemsText.Add("white");
        AllItemsText.Add("black");
        AllItemsText.Add("green");
        AllItemsText.Add("nanika");
        AllItemsText.Add("hati");
        AllItemsText.Add("kyu");

        int[] test = { 0, 3, 5 };
        SetBBText(test);
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("1"))
        {
            RemoveBBText(0);
        }
        if (Input.GetKeyDown("2"))
        {
            RemoveBBText(1);
        }
        if (Input.GetKeyDown("3"))
        {
            RemoveBBText(2);
        }
    }

    public void SetBBText(int[] AnswerItems)
    {
        for(int i = 0; i < 3; i++)
        {
            switch (AnswerItems[i])
            {
                case (int)AllItems.pencil: Text[i].text = AllItemsText[(int)AllItems.pencil]; break;
                case (int)AllItems.eraser: Text[i].text = AllItemsText[(int)AllItems.eraser]; break;
                case (int)AllItems.chalk: Text[i].text = AllItemsText[(int)AllItems.chalk]; break;
                case (int)AllItems.white: Text[i].text = AllItemsText[(int)AllItems.white]; break;
                case (int)AllItems.black: Text[i].text = AllItemsText[(int)AllItems.black]; break;
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
        if (Obj.name.Equals(ItemText))
        {
            RemoveBBText(AllItemsText.IndexOf(ItemText));
        }
    }
}
