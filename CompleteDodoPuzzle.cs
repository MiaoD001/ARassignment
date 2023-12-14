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
            //如果玩家完成了渡渡鸟拼图，则不显示附加了此脚本的物体
        }
    }
}
