using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUIStyle scoreStyle;
    public GUIStyle msgStyle;
    int score = 0;
    string msg = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (msg == "GameOver")
        {
            Time.timeScale = 0f;
        }
    }

    private void OnGUI()
    {
        //GUI.matrix = Matrix4x4.Scale(Vector3.one * 3);
        GUI.Label(new Rect(5, 5, 10, 10), score.ToString(),scoreStyle);
        //画面の真ん中に持っていく
        GUI.Label(new Rect(Screen.width/2-150, Screen.height/2-25, 300, 50), msg, msgStyle);
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int score)
    {
        this.score = score;
    }

    public string GetMsg()
    {
        return msg;

    }

    public void SetMsg(string msg)
    {
        this.msg = msg;
    }
}
