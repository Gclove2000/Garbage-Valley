using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [Header("所调用的背包")]
    public Inventory ThisBag;


    [Header("slot相关设置")]
    public GameObject slotGrid;
    public GameObject emptySlot;

    [Header("放置Slot的列表")]
    public List<GameObject> Items = new List<GameObject>();
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }
    private void OnEnable()
    {
        Refreash();
    }
    public static void Refreash()
    {
        for (int i = 0; i < instance.slotGrid.transform.childCount; i++)
        {
            if(instance.slotGrid.transform.childCount == 0)
            {
                break;
            }
            else{
                Destroy(instance.transform.GetChild(i).gameObject);
                instance.Items.Clear();
            }
        }

        for (int i = 0; i < instance.ThisBag.MyBag.Count; i++)
        {
            instance.Items.Add(Instantiate(instance.emptySlot));
            instance.Items[i].transform.SetParent(instance.slotGrid.transform);
        }
    }
}
