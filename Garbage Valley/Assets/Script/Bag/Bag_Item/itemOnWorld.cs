using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class itemOnWorld : MonoBehaviour
{
    public Inventory ItemOfBag;
    public Item thisItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ADD();
            Destroy(gameObject);
        }
    }
    public void ADD()
    {
        if (!ItemOfBag.MyBag.Contains(thisItem))
        {
            for (int i = 0; i < ItemOfBag.MyBag.Count; i++)
            {
                if(ItemOfBag.MyBag[i] == null)
                {
                    ItemOfBag.MyBag[i] = thisItem;
                    break;
                }
            }
        }
        else
        {
            thisItem.item_num++;
        }
        InventoryManager.Refreash();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
