using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem_1 : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("UI组件")]
    public Text textLabel;
    public Image face;

    [Header("文本文件")]
    public TextAsset textFile;

    public int index;//文本编号
    List<string> textList = new List<string>();
    void Awake()
    {
        GetTextFromFile(textFile);
    }
    private void OnEnable()
    {
        textLabel.text = textList[index];
        index++;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            textLabel.text = textList[index];
            index++;
        }
    }
    
    void GetTextFromFile(TextAsset file)//从文本中读取文档
    {
        textList.Clear();
        index = 0;
        var LineDate = file.text.Split('\n');

        foreach(var line in LineDate)
        {
            textList.Add(line);
        }
    }
}
