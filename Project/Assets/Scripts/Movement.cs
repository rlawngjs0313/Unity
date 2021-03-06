using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    public GameObject bullet;
    public Transform shooting;
    Core core;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
    }

    void Update()
    {
        Moving();
        shoot();
    }

    void Moving()
    {
        if(core.ismyturn == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * core.Speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * core.Speed * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                core.Degree += 0.05f;
                core.Text_Deg += 3.5f;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                core.Degree -= 0.05f;
                core.Text_Deg -= 3.5f;
            }
        }
    }

    public void shoot()
    {
        if(core.ismyturn == true)
        {
            Debug.Log("S");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                core.Speed = 0;
                if (core.doubleclick == false)
                {
                    core.is_shoot = true;
                    Instantiate(bullet, shooting);
                }
            }
            if (core.timeover == true)
            {
                core.Speed = 0;
                if (core.doubleclick == false)
                {
                    core.is_shoot = true;
                    core.timeover = false;
                    Instantiate(bullet, shooting);
                }
            }
        }
    }
}
