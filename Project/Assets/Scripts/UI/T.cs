using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class T : MonoBehaviour
{
    public float time = 20f;
    public Text timer;
    Core core;
    int loop = 0;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
    }

    void Update()
    {
        if (core.ismyturn == true)
        {
            time -= Time.deltaTime;
            if(core.is_shoot == true)
            {
                loop = 1;
            }
            else if (time < 0)
            {
                core.timeover = true;
                time = 20f;
            }
            if(loop == 0)
                timer.text = "Time Remaining : " + time.ToString("F0");
        }
    }
}