using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject EbulletPrefab;
    private float interval = 1.0f; // 何秒間隔で撃つか
    private float timer = 0.5f;　// 時間カウント用のタイマー

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 一定間隔でbulletPrefabを打ち続ける
        if (timer <= 0.0f)　// 分岐条件変更
        {
            Instantiate(EbulletPrefab, transform.position, Quaternion.identity);
            timer = interval; // 間隔をセット
        }

        // タイマーの値を減らす
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }
}
