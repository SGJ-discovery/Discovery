using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Norma : MonoBehaviour
{
    static public int iNormaCount = 0;
    private string sNorma = "";

    private Kyoutaku Kyoutaku;

    [SerializeField]
    private Text tNorma;

    // Use this for initialization
    void Start()
    {
        Kyoutaku = GameObject.Find("kyoutaku").GetComponent<Kyoutaku>();
    }

    // Update is called once per frame
    void Update()
    {
        sNorma = "NORMA: " + iNormaCount + "/3";
        tNorma.text = sNorma;
    }
}
