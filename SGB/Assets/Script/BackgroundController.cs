using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    // �w�i�̃X�N���[�����x
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // �w�i�����ɃX�N���[��������
        transform.position += Vector3.down * Speed * Time.deltaTime;

        // ���܂ōs�������ɖ߂�
        if (transform.position.y < -12f)
        {
            transform.Translate(new Vector3(0, 24f, 0));
        }
    }
}
