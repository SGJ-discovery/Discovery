using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kyoutaku : MonoBehaviour
{
    //[SerializeField]
    private Text Clear;
    //[SerializeField]
    private Norma Norma;

    public GameObject Pen;
    public GameObject Era;
    public GameObject Dic;

    private CreateStage CreateStage;

    bool Flg1 = false;
    bool Flg2 = false;
    bool Flg3 = false;


    // Use this for initialization
    void Start()
    {
        Clear = GameObject.Find("ClearText").GetComponent<Text>();
        Norma = GameObject.Find("NormaText").GetComponent<Norma>();

        Pen.SetActive(false);
        Era.SetActive(false);
        Dic.SetActive(false);

        Clear.text = "";

        CreateStage = GameObject.Find("Stage").GetComponent<CreateStage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Clear == null)
        {
            Clear = GameObject.Find("ClearText").GetComponent<Text>();
        }


        if (Flg1 && Flg2 && Flg3)
        {

            StageClear();

        }


    }

    public void StageClear()
    {
        if (Norma.iNormaCount >= 3)
        {
            Clear.text = "CLEAR STAGE";
            if (Input.GetKeyDown("space"))
            {
                if (CreateStage.stageNum + 1 >= CreateStage.GetStagePrefab())
                {
                    Clear.text = "STAGE COMPLETED";
                    Flg1 = false;
                    Flg2 = false;
                    Flg3 = false;
                    Debug.Log("すべてのステージをクリアしたのでスタッフロール的なものを流しTitleに戻りたい");
                }
                else
                {
                    Norma.iNormaCount = 0;
                    Clear.text = "";
                    CreateStage.StageCreate();
                }
            }
        }
    }


    void pencil()
    {

        Pen.SetActive(true);
        Flg1 = true;

    }

    void eraser()
    {

        Era.SetActive(true);
        Flg2 = true;
    }

    void dictionary()
    {

        Dic.SetActive(true);
        Flg3 = true;
    }

}
