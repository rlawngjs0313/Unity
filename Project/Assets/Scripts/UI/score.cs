using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text sc;
    Core core;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
    }

    void Update()
    {
        sc.text = " Score : " + core.score;
    }
}
