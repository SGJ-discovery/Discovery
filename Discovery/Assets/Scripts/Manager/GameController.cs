using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    // ゲームのステータスを列挙
    public enum GameState
    {
        GameWait,
        GamePlay,
        GameStop,
        GameEnd
    }

    // ゲームの状態
    static public GameState states;
    [SerializeField]
    private GameObject moveScript;
    PlayerMove move;

    void Start () {
        states = GameState.GamePlay;
        move = moveScript.GetComponent<PlayerMove>();
    }
	
	void LateUpdate () {

        switch (states)
        {
            case GameState.GameWait:
                break;
            case GameState.GamePlay:
                move.enabled = true;
                break;
            case GameState.GameStop:
                move.enabled = false;
                break;
            case GameState.GameEnd:
                move.enabled = false;
                break;

        }

	}
}
