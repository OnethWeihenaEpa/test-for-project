using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/*
	this script handles the following...
		i. opens the inventory when the corresponding button is pressed
	   ii. pauses the game while the inventory is open
*/

public class InventoryManager: MonoBehaviour
{
	public GameObject inventory;
	private bool isActive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//note: 'Inventory' is a seperately created input asset that toggles the inventory when the 'I' key is pressed
        if(Input.GetKeyDown(KeyCode.I) && isActive)
        {
	        Time.timeScale = 1; //game moves at regular speed
			inventory.SetActive(false); //deactivates inventory
			isActive = false;
		} else if(Input.GetKeyDown(KeyCode.I) && !isActive)
        {
	        Time.timeScale = 0;  //time is paused during active inventory
			inventory.SetActive(true); //activates inventory
			isActive = true;
		}
		
    }
}
