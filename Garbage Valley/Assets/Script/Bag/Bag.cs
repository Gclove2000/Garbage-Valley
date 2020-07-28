using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bag : MonoBehaviour
{
    [Header("获取背包")]
    public GameObject MyBagForOpen;

    private int num;
    // Start is called before the first frame update
    void Start()
    {
        //num = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B) && num == 0)
        {
            MyBagForOpen.SetActive(true);
            num = 1;
        }
        else if(Input.GetKeyDown(KeyCode.B) && num == 1)
        {
            MyBagForOpen.SetActive(false);
            num = 0;
        }
    }

    public void CloseBag()
    {
        MyBagForOpen.SetActive(false);
        num = 0;
    }
}
