using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMaterialSwitcher : MonoBehaviour
{
    public Material materialA;
    public Material materialB;
    private Renderer triggerRenderer;
    private bool isDodoBone1Inside = false; // 跟踪dodo_bone1是否在触发器内部
    public GameObject dodoBone; // 用于存储dodo_bone1的引用


    void Start()
    {
        // 获取当前对象的Renderer组件
        triggerRenderer = GetComponent<Renderer>();
        // 确保初始材质是A
        triggerRenderer.material = materialA;
    }

    void Update()
    {
        // 检查鼠标左键是否松开并且dodo_bone1在触发器内
        if (isDodoBone1Inside && Input.GetMouseButtonUp(0))
        {
            // 将dodo_bone1的位置设置为触发器的位置
            dodoBone.transform.position = transform.position;
            triggerRenderer.enabled = false;//关闭trigger的render
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // 检查进入触发器的对象是否是dodo_bone1
        if (other.gameObject == dodoBone)
        {
            // 改变材质为B
            triggerRenderer.material = materialB;
            isDodoBone1Inside = true;
            dodoBone = other.gameObject; // 存储对dodo_bone1的引用
        }
    }

    void OnTriggerExit(Collider other)
    {
        // 检查离开触发器的对象是否是dodo_bone1
        if (other.gameObject == dodoBone)
        {
            // 改变材质回A
            triggerRenderer.material = materialA;
            isDodoBone1Inside = false;
        }
    }
}
