using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Degree : MonoBehaviour
{
    Core core;
    public Text degr;
    void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
    }

    void Update()
    {
        degr.text = "Degree : " + core.Degree.ToString("F2");
    }
}
