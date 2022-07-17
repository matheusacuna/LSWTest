using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ValuesItem : MonoBehaviour
{
    public Item item;
    public TextMeshProUGUI price;
    public TextMeshProUGUI nameItem;
    public Image icon;

    // Start is called before the first frame update
    void Start()
    {
        price.text = item.purchasePrice.ToString();
        icon.sprite = item.icon;
        //nameItem.text = item.name;
    }
}
