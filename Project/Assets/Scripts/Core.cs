using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Core : MonoBehaviour
{
    public float Degree = 45f;
    public float Text_Deg = 0f;
    public float Speed = 10f;
    public int score = 0;
    public int dc_cal = 0;
    public int Endgame = 0;
    public bool is_shoot = false;
    public bool is_hit = false;
    public bool is_fail = false;
    public bool is_hit_AI = false;
    public bool is_fail_AI = false;
    public bool doubleclick = false;
    public bool timeover = false;
    public bool ismyturn = true;
    public Vector3 pos2;
    public Vector3 pos1;
    public Text win_lose;
    public GameObject texts;
    T t;
    AI aI;
    GameObject AI_Bullet;
    private void Awake()
    {
        texts.SetActive(false);
    }
    void Start()
    {
        t = GameObject.Find("Timer").GetComponent<T>();
        aI = GameObject.Find("EnemyAI").GetComponent<AI>();
    }

    void Update()
    {
        initialized();
        Reset();
        Winning();
    }

    void initialized()
    {
        if (is_hit == true)
        {
            score ++;
            Speed = 10f;
            t.time = 20f;
            is_hit = false;
            ismyturn = false;
            doubleclick = false;
            t.timer.text = "Time Remaining : " + t.time.ToString("F0");
        }
        if (is_fail == true)
        {
            Speed = 10f;
            t.time = 20f;
            ismyturn = false;
            is_fail = false;
            doubleclick = false;
            t.timer.text = "Time Remaining : " + t.time.ToString("F0");
        }
        if(is_hit_AI == true)
        {
            is_hit_AI = false;
            score --;
            dc_cal --;
            aI.doubleclick --;
            t.loop = 0;
            aI.moved = false;
            ismyturn = true;
        }
        if(is_fail_AI == true)
        {
            is_fail_AI = false;
            dc_cal --;
            aI.doubleclick --;
            t.loop = 0;
            aI.moved = false;
            ismyturn = true;
        }
    }
    void Reset()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("#1");
        }
    }
    void Winning()
    {
        if(score >= 3)
        {
            Endgame ++;
            win_lose.text = "You Win";
            texts.SetActive(true);
        }
        if(score < 0)
        {
            Endgame ++;
            win_lose.text = "You Lose";
            texts.SetActive(true);
        }
    }
}
