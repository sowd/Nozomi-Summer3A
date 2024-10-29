using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowOrientation : MonoBehaviour
{
    Quaternion oriInit;
    // Start is called before the first frame update
    void Start()
    {
        oriInit = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject hand = GameObject.Find("BowTarget");

        transform.LookAt(hand.transform.position);
        //Vector3 oriTarget = hand.transform.position - transform.position;

        //transform.rotation = Quaternion.FromToRotation(transform., oriTarget);
        //transform.rotation = hand.transform.rotation;
        //transform.rotation = Quaternion.FromToRotation(rotation, hand.transform.up);
        //transform.rotation = Quaternion.FromToRotation(transform.up, hand.transform.up);
    }
}
