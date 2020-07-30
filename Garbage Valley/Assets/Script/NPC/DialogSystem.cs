﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem: MonoBehaviour
{
    // Start is called before the first frame update
    [Header("UI组件")]
    public Text textLabel;
    public Image face;

    [Header("文本文件")]
    public TextAsset textFile;
    public float textSpeed;
    public int index;//文本编号

    [Header("头像")]
    public Sprite face01, face02;

    private bool textFinished;//文本阅读结束
    private bool textSkip;//文本阅读跳过
    List<string> textList = new List<string>();
    void Awake()
    {
        GetTextFromFile(textFile);
    }
    private void OnEnable()
    {
        textFinished = true;
        StartCoroutine(SetTextUI());

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
        //if (Input.GetKeyDown(KeyCode.E) && textFinished) 
        //{
        //    StartCoroutine(SetTextUI());
        // }
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(textFinished && !textSkip)//如果上一个文本输入完了且没有跳过
            {
                StartCoroutine(SetTextUI());
            }
            else if(!textFinished && !textSkip)//文本没输入完而且跳过的真值还没有设置
            {
                textSkip = true;//要跳过
            }
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

    IEnumerator SetTextUI()//控制文本输出
    {
        textFinished = false;
        textLabel.text = "";
        switch(textList[index])
        {
            case "A":
                index++;
                face.sprite = face01;
                break;
            case "B":
                index++;
                face.sprite = face02;
                break;
        }

        //for (int i =0;i < textList[index].Length;i++)
        //{
        //    textLabel.text += textList[index][i];
        //    yield return new WaitForSeconds(textSpeed);
        //}
        int site = 0;//文本的位置
        while(!textSkip && site < textList[index].Length  )//没有跳过
        {
            textLabel.text += textList[index][site];
            site++;
            yield return new WaitForSeconds(textSpeed);
        }
        textLabel.text = textList[index];
        textSkip = false;
        index++;
        textFinished = true;
    }
}
