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
                Debug.Log("��ü ���� ���� : " + Total_count);
                Debug.Log("���� ���� ���� : " + Red_count);
                Debug.Log("�Ķ� ���� ���� : " + ColorVisualize.Blue_count);
            }
        }

    }

    void instacing()
    {
        Rigidbody instance = Instantiate(target, transform.position, spawnerPosition.rotation);
        Total_count += 1;
    }
}
