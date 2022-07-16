using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itemDefault;
    public Transform grid;

    void Start()
    {

       CreateDisplay();
    }

    void Update()
    {

    }

    private void CreateDisplay()
    {
        for (int i = 0; i < inventory.itens.Count; i++)
        {
            var obj = Instantiate(itemDefault, grid);
            obj.GetComponent<ValuesItem>().item = inventory.itens[i];
        }
    }
}
