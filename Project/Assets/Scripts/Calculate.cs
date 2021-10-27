using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    public float speed = 1000f;
    new Rigidbody rigidbody;
    Core core;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        core = GameObject.Find("GameSystem").GetComponent<Core>();
    }

    void Update()
    {
        Cal();
    }

     void Cal()
    {
        if (core.is_shoot == true)
        {
            Vector3 calcu_Degreed = new Vector3(Mathf.Cos(core.Degree) * speed, Mathf.Sin(core.Degree) * speed);
            rigidbody.AddForce(calcu_Degreed);
            core.is_shoot = false;
            core.doubleclick = true;
            core.Degree = 45f;
            core.Text_Deg = 45f;
        }
    }





    public void OnTriggerEnter(Collider collider) 
    {
        if (collider.tag == "Plane")
        {
            core.pos2 = transform.position + new Vector3(0, 2, 0);
            core.pos1 = GameObject.Find("Player").transform.position;
            Object.Destroy(this.gameObject);
            core.is_fail = true;
        }
        if (collider.tag == "Enemy")
        {
            core.pos2 = transform.position + new Vector3(0, 2, 0);
            core.pos1 = GameObject.Find("Player").transform.position;
            Object.Destroy(this.gameObject);
            core.is_hit = true;
        }
    }
}