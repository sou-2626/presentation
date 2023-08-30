using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject EbulletPrefab;
    private float interval = 1.0f; // ���b�Ԋu�Ō���
    private float timer = 0.5f;�@// ���ԃJ�E���g�p�̃^�C�}�[

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ���Ԋu��bulletPrefab��ł�������
        if (timer <= 0.0f)�@// ��������ύX
        {
            Instantiate(EbulletPrefab, transform.position, Quaternion.identity);
            timer = interval; // �Ԋu���Z�b�g
        }

        // �^�C�}�[�̒l�����炷
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }
}
