using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController_Start : MonoBehaviour          //유니티가 제공하는 걸 상속받는다.
{
    Animator Anim;

    // Start is called before the first frame update
    void Start()      //처음 실행하는 것. 변수값 초기, 오브젝트 불러오기. 딱 한번 업데이트 이전에 실행해야 할 코드들.
    {
        
        
        Anim = GetComponent<Animator>();
        Anim.speed = 0.0f;      //바람개비스피드값 조정
    }

    // Update is called once per frame
    void Update() //반복해서 실행해야할 코드들. 키보드 입력하는, 마우스 위치 파악 등.. 
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Anim.speed = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.speed = 0;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Anim.speed = 2.0f;
        }
    }
}
