using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBullet : MonoBehaviour
{
    private float moveSpeed = 1.0f;
    Vector3 playerPos;//playerÇÃç¿ïWÇì¸ÇÍÇÈïœêî
    GameObject player;
    Vector3 arrows;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playerPos = player.transform.position;
        arrows = (playerPos - this.transform.position).normalized * moveSpeed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += arrows / 20;
        if (transform.position.y < -5.0f || transform.position.x < -5.0f || transform.position.x > 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
