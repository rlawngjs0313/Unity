using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Core : MonoBehaviour
{
    public float Degree = 45.0f;
    public float Speed = 10f;
    public int score = 0;
    public bool is_shoot = false;
    public bool is_hit = false;
    public bool is_fail = false;
    public bool is_hit_AI = false;
    public bool is_fail_AI = false;
    public bool doubleclick = false;
    public int dc_cal = 0;
    public bool timeover = false;
    public bool ismyturn = true;
    public Vector3 pos2;
    public Vector3 pos1;
    T t;
    AI aI;
    GameObject AI_Bullet;
    private void Awake()
    {
        
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
            aI.moved = false;
            ismyturn = true;
        }
        if(is_fail_AI == true)
        {
            is_fail_AI = false;
            dc_cal --;
            aI.doubleclick --;
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
}
