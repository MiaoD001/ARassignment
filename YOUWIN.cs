using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YOUWIN : MonoBehaviour
{
    [Header ("�ɶ���ĹǼܺ���ȷλ��")]
    public GameObject[] bones; // ���е�bone����
    public Transform[] targetPositions; // ���е�Ŀ��λ��
    public float snapDistance = 0.5f; // �ɽ��ܵ���Χ


    [Header("�����ɶ���ͱ�������")]
    public GameObject text1;
    public GameObject backgroundColor;
    public GameObject dodoBody;
    public static bool playerFinishedDodo = false;//��¼�����ɶɶ���ƴͼ����Ϣ

    void Update()
    {
        if (CheckAllBonesInPlace())
        {

            text1.SetActive(true);
            backgroundColor.SetActive(true);
            dodoBody.SetActive(true);
            // ������ִ�к������������������һ���ؿ�

            playerFinishedDodo = true;//��������ƴͼ����Ϣ�������������ļ�

        }
    }

    bool CheckAllBonesInPlace()
    {
        for (int i = 0; i < bones.Length; i++)
        {
            if (Vector3.Distance(bones[i].transform.position, targetPositions[i].position) > snapDistance)
            {
                return false;
            }
        }
        return true;
    }
}
