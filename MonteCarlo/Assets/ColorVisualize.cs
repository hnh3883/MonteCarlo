using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorVisualize : MonoBehaviour
{
    private Rigidbody Rigid;
    int y_position;

    Vector3 CapsulePosition;

    public static int Blue_count;

    bool Trigger_TF;
    // Start is called before the first frame update
    void Start()
    {
        Trigger_TF = true;
        Rigid = GetComponent<Rigidbody>();
        GetComponent<MeshRenderer>().material.color = Color.red;
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dd");
        if(other.gameObject.tag == "ground")
        {
            CapsulePosition = this.gameObject.transform.position;
            colorAndcount();
        }
    }

    void colorAndcount()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        Blue_count += 1;
    }

}
