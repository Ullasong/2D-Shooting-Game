using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 순서1) 방향키로 사용자 입력을 받아서 플레이어를 앞뒤좌우로 이동시키자
public class PlayerMove : MonoBehaviour
{
    private float speed = 5f;
    private Transform tr;
    private GameObject target;
    public int score = 0;
    
    void Start() 
    {
        tr = GetComponent<Transform>(); 
    }

    void Update() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = ((Vector3.forward * v) + (Vector3.right * h));

        tr.Translate(dir.normalized * speed * Time.deltaTime); 

        //만약 Shift키를 누르는 동안에만, speed가 2배가 된다.
        if (Input.GetKey(KeyCode.LeftShift)) tr.Translate(dir.normalized * (speed * 2 ) * Time.deltaTime);  
    }

    public void AddScore(int point) {
        score += point;
    }  
}
