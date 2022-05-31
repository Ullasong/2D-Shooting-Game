using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 2. 캐릭터 회전시키기
// 캐릭터가 앞을 보고 있는 상태에서 <- 키를 한번 누르면 90도 회전을 한다.

public class PlayerMove_14 : MonoBehaviour
{
    public float movespeed = 3;
    private Transform transform;
    // 1. 캐릭터 이동시키기
    // 모든 게임오브젝트가 가지고 있는 Transfrom의 Poision 값을 변경하는 방식으로 캐릭터를 이동시키기

    void Start()
    {
        transform = GetComponent<Transform>();
        // 2. 컴포넌트의 캐시처리
        // 매프래임마다 컴포넌트에 접근하는 것보다 Start함수에서 미리 변수에 담아두고 해당 변수에 접근하는 방식이 더 빠르다.
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 direction = horizontal * Vector3.right;
        Debug.Log(direction);

        transform.Translate(direction.normalized * movespeed * Time.deltaTime);
    }
}