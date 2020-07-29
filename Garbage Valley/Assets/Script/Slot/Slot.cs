using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
    public int ID;
    public Item slotitem;
    public Image slotimage;
    public Text slotNum;
    public GameObject iteminslot;
    public string slotinfor;
    public void onclick()
    {
        InventoryManager.UpdateItemInfo(slotinfor);
        
    }
    public void setupSlot(Item item)
    {
        if (item == null)
        {
            iteminslot.SetActive(false);
            return;
        }

        slotimage.sprite = item.item_image;
        slotNum.text = item.item_num.ToString();
        slotinfor = item.item_inform;
    }
}
