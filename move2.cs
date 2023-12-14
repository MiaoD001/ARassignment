using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private float originalZPosition;

    void OnMouseDown()
    {
        //Debug.Log("鼠标按下");
        // 将物体的坐标从世界坐标转换为屏幕坐标
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        originalZPosition = transform.position.z; // 保存原始的Z轴坐标

        // 计算物体的世界坐标和鼠标在屏幕上的坐标之间的偏移
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        //Debug.Log("拖动");
        // 更新鼠标在屏幕上的坐标
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        // 将鼠标屏幕坐标转换成三维坐标
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;

        // 使用原始的Z轴坐标
        currentPosition.z = originalZPosition;

        // 更新物体的位置
        transform.position = currentPosition;
    }
}
