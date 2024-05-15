using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter : MonoBehaviour
{
    public GameObject opponent;
    public AnimationClip attack;
    private double impactLength;
    public int damage;
    public double impactTime;
    public bool impacted;
    public float range;

    void Start()
    {
        impactLength = (GetComponent<Animation>()["attack"].length * impactTime);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && inRange())
        {
            GetComponent<Animation>().CrossFade("attack");
            //ClickToMove.attack = true;

            if (opponent != null)
            { 
                transform.LookAt(opponent.transform.position);
                //opponent.GetComponent<mob>().getHit(damage);
            }
        }

        if(!GetComponent<Animation>().IsPlaying("attack"))
        {
            //ClickToMove.attack = false;
            impacted = false;
        }
        impact();
    }

    void impact()
    {
        if (opponent != null && GetComponent<Animation>().IsPlaying("attack") && !impacted)
        {
            if ((GetComponent<Animation>()["attack"].time > GetComponent<Animation>()["attack"].length * impactTime))
            {
                //opponent.GetComponent<mob>().getHit(damage);
                impacted = true;
            }
        }
    }

    bool inRange()
    {
        if (Vector3.Distance(transform.position, transform.position) <= range)
        {
            return true;
        }
        else
        {
            return false;
        }

        //return (Vector2.Distance(transform.position, transform.position) <= range);
    }
}
