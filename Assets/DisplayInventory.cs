using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;


public enum Character {Player, NPC,};
public class DisplayInventory : MonoBehaviour
{
    public Character character;
    public Inventory inventory;
    public GameObject itemDefault;
    public Transform grid;


    private void OnEnable()
    {
        CreateDisplay();
    }

    public void CreateDisplay()
    {
        if(grid.childCount <= 0)
        {
            if(character == Character.NPC)
            {
                for (int i = 0; i < inventory.itens.Count; i++)
                {
                    var obj = Instantiate(itemDefault, grid);
                    obj.GetComponent<ValuesItem>().item = inventory.itens[i];
                    obj.transform.Find("Icon").GetComponent<Button>().onClick.AddListener(() => ShoppingManager.instance.GetItem(obj.GetComponent<ValuesItem>().item, obj));
                }
            } 

            if(character == Character.Player)
            {
                for (int i = 0; i < inventory.itens.Count; i++)
                {
                    var obj = Instantiate(itemDefault, grid);
                    obj.GetComponent<ValuesItem>().item = inventory.itens[i];
                    obj.transform.GetChild(1).GetComponent<TextMeshProUGUI>().enabled = false;
                    obj.transform.Find("Icon").GetComponent<Button>().onClick.AddListener(() => ShoppingManager.instance.GetItem(obj.GetComponent<ValuesItem>().item, obj));
                }
            }    
        }
        else
        {
            Debug.Log("nao pode instanciar");
        }
    }
}
