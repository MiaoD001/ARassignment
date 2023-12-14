using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    private void Start()
    {
        
    }

    void OnMouseDown()
    {
        //Debug.Log("��갴��");
        // ��������������������ת��Ϊ��Ļ����
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        // �������������������������Ļ�ϵ�����֮���ƫ��
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        //Debug.Log("�϶�");
        // �����������Ļ�ϵ�����
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        // �������Ļ����ת������ά����
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;

        // ���������λ��
        transform.position = currentPosition;
    }
}
