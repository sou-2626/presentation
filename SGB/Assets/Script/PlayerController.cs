using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float interval = 0.2f; // ���b�Ԋu�Ō���
    private float timer = 2f;�@// ���ԃJ�E���g�p�̃^�C�}�[

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ��������
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 8f;

        transform.position = new Vector3(
            // �I�u�W�F�N�g���ړ��ł���͈͂̐���
            Mathf.Clamp(transform.position.x + dx, -2.7f, 2.7f),
            -4.5f,
            0f
        );

        // ���Ԋu��bulletPrefab��ł�������
        if (timer <= 0.0f)�@// ��������ύX
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            timer = interval; // �Ԋu���Z�b�g
        }

        // �^�C�}�[�̒l�����炷
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }

    }
}
