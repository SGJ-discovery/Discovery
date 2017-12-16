using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAitem : MonoBehaviour {

    private bool hitFlag; // 当たったかどうかのフラグ
    private GameObject obj; // 当たったオブジェクトを格納する

    void Start()
    {
        hitFlag = false;
    }

    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit)
    {
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Aitem"))
        {
            Debug.Log("hit");
            hitFlag = true;
            obj = hit.gameObject;
        }
        else
        {
            hitFlag = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            // このコンポーネントを持つGameObjectを破棄する
            Destroy(obj.gameObject);
        }
    }
}
