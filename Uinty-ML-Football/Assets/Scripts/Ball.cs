using UnityEngine;

public class Ball : MonoBehaviour
{
    /// <summary>
    /// 足球是否進入球門
    /// </summary>
    public static bool complete;

    /// <summary>
    /// 觸發開始事件
    /// </summary>
    /// <param name="other">碰到的物件碰撞資訊</param>
    private void OnTriggerEnter(Collider other)
    {
        // 如果碰到物件的名稱等於"Sensor"
        if (other.name == "Sensor")
        {
            // 進入球門
            complete = true;
        }
    }
}
