using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValuesItem : MonoBehaviour
{
    public Item item;
    public TextMeshProUGUI price;
    public TextMeshProUGUI nameItem;

    // Start is called before the first frame update
    void Start()
    {
        price.text = item.price.ToString();
        //nameItem.text = item.name;
    }
}
