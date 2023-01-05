using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCapsule : MonoBehaviour
{
    public Rigidbody target;
    public Transform spawnerPosition;
    float x_random;
    float z_random;

    public static int Total_count;
    public static int Red_count;
    void Start()
    {

    }

    private void Update()
    {
        x_random= Random.Range(-65.0f, -15.0f);
        z_random = Random.Range(-45.0f, 5.0f);
        transform.position = new Vector3(x_random, 10.15f, z_random);
        instacing();
        for(int i = 1;  i <= 10; i++)
        {
            if (Total_count == 500 * i)
            {
                Red_count = Total_count - ColorVisualize.Blue_count;
                Debug.Log("전체 점의 개수 : " + Total_count);
                Debug.Log("빨간 점의 개수 : " + Red_count);
                Debug.Log("파란 점의 개수 : " + ColorVisualize.Blue_count);
            }
        }

    }

    void instacing()
    {
        Rigidbody instance = Instantiate(target, transform.position, spawnerPosition.rotation);
        Total_count += 1;
    }
}
