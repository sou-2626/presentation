using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject EnemyPrefab2;
    public GameObject EnemyPrefab3;
    float span = 1f;
    float delta = 0;
    int Enum_1 = 0;
    int Enum_2 = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go1 = Instantiate(EnemyPrefab);
            float px1 = Random.Range(-2.8f, 2.8f);
            go1.transform.position = new Vector3(px1, 4.5f, 0);
            GameObject go3 = Instantiate(EnemyPrefab3);
            float px3 = Random.Range(-2.8f, 2.8f);
            go3.transform.position = new Vector3(px3, 4.5f, 0);
            if (Enum_1 >= 100)
            {
                GameObject go2 = Instantiate(EnemyPrefab2);
                float px2 = Random.Range(-2.8f, 2.8f);
                go2.transform.position = new Vector3(px2, 4.5f, 0);
            }

            span -= 0.001f;
            Enum_1 += 1;
            Enum_2 += 1;
        }

        if (Enum_1 == 100)
        {
            Enum_1 = 0;
            span -= 0.01f;
        }

        if (Enum_2 == 500)
        {
            Enum_2 = 0;
            span -= 0.1f;
        }
    }
}
