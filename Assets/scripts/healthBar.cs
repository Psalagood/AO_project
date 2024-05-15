using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public int health;
    public Slider hpStat;
    private GameObject canvas;

    void Start()
    {
        //hpStat = transform.Find("Canvas/Panel/Slider").gameObject.GetComponent<Slider>();
        canvas = transform.Find("Canvas").gameObject;
    }
    
    public void GetDamage(int damage)
    {
        health -= damage;
        hpStat.value = health;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        GetDamage(25);
    }

    //void Update()
    //{
    //    if(canvas.transform.rotation != Camera.main.transform.rotation) 
    //    {
    //        canvas.transform.rotation = Camera.main.transform.rotation;
    //    }
    //}
}
