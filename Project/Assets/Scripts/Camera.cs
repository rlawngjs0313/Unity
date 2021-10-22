using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject PlayerPos;
    public Vector3 BulletPos;
    Core core;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
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
            BulletPos = GameObject.FindWithTag("Bullet").transform.position;
            BulletPos += new Vector3(0, 0, -20);
            transform.position = BulletPos;
        }
        if(core.ismyturn != true)
        {
            transform.position += GameObject.FindWithTag("Enemy").transform.position;
        }
    }
}
