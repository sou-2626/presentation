using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 1f;
    float delta = 0;
    int Enum_1 = 0;
    int Enum_2 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab) as GameObject;
            float px = Random.Range(-2.8f, 2.8f);
            go.transform.position = new Vector3(px, 4.5f, 0);
            span -= 0.001f;
            Enum_1 += 1;
            Enum_2 += 1;
        }
        if (Enum_1 == 100)
        {
            Enum_1 = 0;
            span -= 0.01f;
        }
        if (Enum_2 == 1000)
        {
            Enum_2 = 0;
            span -= 0.1f;
        }
    }
}
