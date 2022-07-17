using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Itens", menuName = "ScriptableObject/Item", order = 0)]
public class Item : ScriptableObject
{
    public string nameItem;
    public int purchasePrice;
    public int resalePrice;
    public Sprite sprite;
    public Sprite icon;
    //public Image icon;
    //public GameObject item;
}
