using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteDodoPuzzle : MonoBehaviour
{


    void Update()
    {
        if (YOUWIN.playerFinishedDodo == true)
        {
            gameObject.SetActive(false);
            //����������˶ɶ���ƴͼ������ʾ�����˴˽ű�������
        }
    }
}
