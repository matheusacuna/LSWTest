using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class InteractionManager : MonoBehaviour
{
    bool isTouchNPC;
    [SerializeField] private GameObject dialogue;
    [SerializeField] private InputManager myInput;
    [SerializeField] private GameObject displayInventory;

    private void Update()
    {
        if(isTouchNPC)
        {
            if(myInput.input.Player.Interaction.triggered)
            {
                dialogue.SetActive(true);     
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("NPC"))
        {
            isTouchNPC = true;
        }
    }

    public void OpenInventory()
    {
        //displayInventory.GetComponent<DisplayInventory>().inventory = 
        displayInventory.SetActive(true);
    }
}
