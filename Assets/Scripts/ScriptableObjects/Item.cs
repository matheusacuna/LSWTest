using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Equips{Hair, Shirt, Pants, Shoe};

[CreateAssetMenu(fileName = "Itens", menuName = "ScriptableObject/Item", order = 0)]
public class Item : ScriptableObject
{
    public Equips typeEquips;
    public string nameItem;
    public int purchasePrice;
    public int resalePrice;
    public List<Sprite> sprites = new List<Sprite>();
    public Sprite icon;
    //public Image icon;
    //public GameObject item;
}
