using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove : MonoBehaviour
{
    [Header("获取玩家")]
    public Transform PlayerTransform;

    [Header("获取NPC动画")]
    public Animator NPCAnimator;

    [Header("设置转头速度")]
    public bool HavePlayer;
    // Start is called before the first frame update
    void Start()
    {
        HavePlayer = false;
        //PlayerTransform = GetComponent<Transform>();
        NPCAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Trun();
    }

    public void Trun()
    {
        if (HavePlayer) { 
        
        if (PlayerTransform.position.x < transform.position.x)
        {
            NPCAnimator.SetBool("Left", true);
        }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            Debug.Log("catch you");
            HavePlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            HavePlayer = false;
        }
    }
}
