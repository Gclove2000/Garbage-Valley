using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Item" , menuName ="Item/New Item")]
public class Item : ScriptableObject
{
    public string item_name;
    public int item_num;
    public Sprite item_image;
    [TextArea]
    public string item_inform;
}
