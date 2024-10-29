using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowOrientation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject onString = GameObject.Find("BowTarget");

        transform.LookAt(onString.transform.position);
    }
}
