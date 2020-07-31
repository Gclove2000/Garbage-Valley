using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFellow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;//人物位置
    [Header("确定相机的范围")]
    public Vector2 leftDown;
    public Vector2 rightUp;
    public float smooting;
    public Vector2 test;
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        if(target != null)
        {
            if(transform.position != target.position)
            {
                Vector3 targetPos = target.position;
                targetPos.x = Mathf.Clamp(targetPos.x, leftDown.x, rightUp.x);
                targetPos.y = Mathf.Clamp(targetPos.y, leftDown.y, rightUp.y);
                transform.position = Vector3.Lerp(transform.position, targetPos, smooting);

            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
