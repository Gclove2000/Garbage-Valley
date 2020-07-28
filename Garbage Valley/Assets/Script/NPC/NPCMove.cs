using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove : MonoBehaviour
{
    [Header("获取NPC")]
    public Transform NPCTransform;

    [Header("获取NPC动画")]
    public Animator NPCAnimator;

    [Header("设置转头速度")]
    public bool HavePlayer;
    // Start is called before the first frame update
    void Start()
    {
        HavePlayer = false;
        //PlayerTransform = GetComponent<Transform>();
        //NPCAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Trun();
    }

    public void Trun()
    {
        Filp();
        if (HavePlayer) {
            NPCAnimator.SetFloat("Horizontal", transform.position.x - NPCTransform.position.x);  //通过两个位置相减就可以了，负数向左，正数向右
            NPCAnimator.SetFloat("Vertical", transform.position.y - NPCTransform.position.y);
        }
        
    }
    void Filp()
    {
        if (NPCTransform.position.x > transform.position.x)
        {
            NPCTransform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (NPCTransform.position.x < transform.position.x)
        {
            NPCTransform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Debug.Log("catch you");
            HavePlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
           
        {
            HavePlayer = false;
        }
    }
}
