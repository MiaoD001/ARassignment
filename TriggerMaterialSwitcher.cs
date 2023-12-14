using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMaterialSwitcher : MonoBehaviour
{
    public Material materialA;
    public Material materialB;
    private Renderer triggerRenderer;
    private bool isDodoBone1Inside = false; // ����dodo_bone1�Ƿ��ڴ������ڲ�
    public GameObject dodoBone; // ���ڴ洢dodo_bone1������


    void Start()
    {
        // ��ȡ��ǰ�����Renderer���
        triggerRenderer = GetComponent<Renderer>();
        // ȷ����ʼ������A
        triggerRenderer.material = materialA;
    }

    void Update()
    {
        // ����������Ƿ��ɿ�����dodo_bone1�ڴ�������
        if (isDodoBone1Inside && Input.GetMouseButtonUp(0))
        {
            // ��dodo_bone1��λ������Ϊ��������λ��
            dodoBone.transform.position = transform.position;
            triggerRenderer.enabled = false;//�ر�trigger��render
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // �����봥�����Ķ����Ƿ���dodo_bone1
        if (other.gameObject == dodoBone)
        {
            // �ı����ΪB
            triggerRenderer.material = materialB;
            isDodoBone1Inside = true;
            dodoBone = other.gameObject; // �洢��dodo_bone1������
        }
    }

    void OnTriggerExit(Collider other)
    {
        // ����뿪�������Ķ����Ƿ���dodo_bone1
        if (other.gameObject == dodoBone)
        {
            // �ı���ʻ�A
            triggerRenderer.material = materialA;
            isDodoBone1Inside = false;
        }
    }
}
