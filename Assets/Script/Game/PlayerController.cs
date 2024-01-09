// PlayerController 脚本
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball1; // 小球1
    public GameObject ball2; // 小球2
    public GameObject ball3; // 小球
    public GameObject ball4;
    public GameObject ball5;
    
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
            controlledBall = ball2;


        }
        else if (controlledBall == ball2)
        {
            controlledBall = ball3;

        }
        else if (controlledBall == ball3)
        {
            controlledBall = ball4;


        }
        else if (controlledBall == ball4)
        {
            controlledBall = ball5;


        }
    }
}
