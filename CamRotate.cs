using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    Vector3 nearPosition;
    Vector3 farPosition;


    // Start is called before the first frame update
    void Start()
    {
        //카메라의 가장 가까운 위치를 현재 위치로 지정한다.
        //nearPosition를 나의 위치(현재 위치)로
        nearPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
