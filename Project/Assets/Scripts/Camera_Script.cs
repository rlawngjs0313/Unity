using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    public GameObject PlayerPos;
    public GameObject AIPos;
    AI ai;
    Core core;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        ai = GameObject.Find("EnemyAI").GetComponent<AI>();
    }

    void Update()
    {
        move();
    }

    void move()
    {
        if (core.is_shoot == false)
        {
            transform.position = PlayerPos.transform.position;
        }
        if (GameObject.FindWithTag("Bullet"))
        {
            transform.position = GameObject.FindWithTag("Bullet").transform.position + new Vector3(0, 0, -20);
        }
        if(core.ismyturn != true)
        {
            transform.position = AIPos.transform.position + new Vector3(0, 0, -20);
        }
        if(GameObject.FindWithTag("Bullet_AI"))
            transform.position = GameObject.FindWithTag("Bullet_AI").transform.position + new Vector3(0, 0, -20);
    }
}