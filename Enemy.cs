using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//아래로 내러온다.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    private Transform transform;
    private Vector3 dir;
    private GameObject target;

    void Start()
    {
        target = GameObject.Find("Player");
        transform = GetComponent<Transform>();
        int result = Random.Range(0, 10);
        if (result < 9) {
            dir = target.transform.position - transform.position;
        }
        else dir = Vector3.down;
    }
    
    void Update()
    {
        transform.Translate(dir.normalized * speed * Time.deltaTime);
    }

    // 어떤 충돌체가 나와 부딪히면 호출된다.
    // 만약 그 충돌체가 Bullet이라면,
    // target 오브젝트에 있는 PlayerMove클래스에 접근해서
    // AddScore 함수를 호출해서 1점씩 올린다.
    private void OnCollisionEnter(Collision other) {
        Destroy(gameObject);
        Destroy(other.gameObject);

        if (other.gameObject.name.Contains("Bullet")) {
            PlayerMove player = target.GetComponent<PlayerMove>();
            player.AddScore(1);
            }
        }
    }
