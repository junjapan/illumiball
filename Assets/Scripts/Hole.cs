using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public string targetTag;
    bool isHolding;

    public bool IsHolding()
    {
        return isHolding;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == targetTag)
        {
            isHolding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == targetTag)
        {
            isHolding = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        if(other.gameObject.tag == targetTag)
        {
            r.velocity *= 0.9f;
            //velocityはいきなり速度成分をいじれる。毎回1割ずつ減少させて収束させる。
            r.AddForce(direction * -20.0f, ForceMode.Acceleration);
            //addforceは、自然な力
        }
        else
        {
            r.AddForce(direction * 200.0f, ForceMode.Impulse);
        }
    }
}
