// PlayerController 脚本
using UnityEngine;

public class PlayerControllerC : MonoBehaviour
{
    public GameObject ball1; // 小球1
    public GameObject ball2; // 小球2
    public GameObject ball3; // 小球3


    public GameObject controlledBall; // 当前受控制的小球

    void Start()
    {
        controlledBall = ball1; // 初始控制小球1
    }

    public void SwitchControlledBall()
    {
        // 切换受控制的小球
        if (controlledBall == ball1)
        {
            // 添加条件：controlledBall 为 ball1 且场景中存在标签为 "Money" 的物体
            if (GameObject.FindGameObjectWithTag("Money") != null)
            {
                controlledBall = ball2;
            }
            else
            {
                controlledBall = ball3; // 如果没有 "Money" 物体，切换到 ball3
            }
        }

        else if (controlledBall == ball2)
        {
            controlledBall = ball3;
        }

        // 继续添加其他切换条件
    }

}
