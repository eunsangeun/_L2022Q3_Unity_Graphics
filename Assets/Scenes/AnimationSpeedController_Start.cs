using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController_Start : MonoBehaviour          //����Ƽ�� �����ϴ� �� ��ӹ޴´�.
{
    Animator Anim;

    // Start is called before the first frame update
    void Start()      //ó�� �����ϴ� ��. ������ �ʱ�, ������Ʈ �ҷ�����. �� �ѹ� ������Ʈ ������ �����ؾ� �� �ڵ��.
    {
        
        
        Anim = GetComponent<Animator>();
        Anim.speed = 0.0f;      //�ٶ������ǵ尪 ����
    }

    // Update is called once per frame
    void Update() //�ݺ��ؼ� �����ؾ��� �ڵ��. Ű���� �Է��ϴ�, ���콺 ��ġ �ľ� ��.. 
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
