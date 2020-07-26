using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("控制人物动作")]
    public Animator animatior;
    //控制角色的动作
    // Start is called before the first frame update
    [Header("设置人物移动速度")]
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Filp();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        //读取x,y和magnitude参数，实现动画的控制
        animatior.SetFloat("Horizontal", movement.x);
        animatior.SetFloat("Vertical", movement.y);
        animatior.SetFloat("Magnitude", movement.magnitude);
        transform.position = transform.position + speed*movement * Time.deltaTime;
    }
    void Filp()
    {
        if (animatior.GetFloat("Horizontal") < -0.1f)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (animatior.GetFloat("Horizontal") > 0.1f)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
