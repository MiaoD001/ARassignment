using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YOUWIN : MonoBehaviour
{
    [Header ("渡渡鸟的骨架和正确位置")]
    public GameObject[] bones; // 所有的bone物体
    public Transform[] targetPositions; // 所有的目标位置
    public float snapDistance = 0.5f; // 可接受的误差范围


    [Header("完整渡渡鸟和背景故事")]
    public GameObject text1;
    public GameObject backgroundColor;
    public GameObject dodoBody;
    public static bool playerFinishedDodo = false;//记录玩家完成渡渡鸟拼图的信息

    void Update()
    {
        if (CheckAllBonesInPlace())
        {

            text1.SetActive(true);
            backgroundColor.SetActive(true);
            dodoBody.SetActive(true);
            // 在这里执行后续操作，比如进入下一个关卡

            playerFinishedDodo = true;//把玩家完成拼图的消息告诉其他代码文件

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
