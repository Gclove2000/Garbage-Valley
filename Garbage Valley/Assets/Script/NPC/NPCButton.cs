using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCButton : MonoBehaviour
{
    [Header("获取NPC对应的Button的GameObjeck")]
    public GameObject Button;

    [Header("获取与NPC对话的UI")]
    public GameObject talkUI;

    [Header("设置触发对话事件的按键")]
    public KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);  
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Button.activeSelf && Input.GetKeyDown(key))
        {
            talkUI.SetActive(true);
        }
    }
}
