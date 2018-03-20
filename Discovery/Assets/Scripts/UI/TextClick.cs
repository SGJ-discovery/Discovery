using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextClick : MonoBehaviour {

    [SerializeField]
    SelectMenu SelectMenu;
    private Text ItemText;

    // Use this for initialization
    void Start () {
        ItemText = this.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickText()
    {
        SelectMenu.CloseMenu(ItemText.text);
    }
}
