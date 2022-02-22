using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inventar : MonoBehaviour
{
    public GameObject[] toggles;
    private bool ability1 = false;
    private bool ability2 = false;
    private bool ability3 = false;
    private bool ability4 = false;
    private bool ability5 = false;

    public void newAbility1()
    {
        ability1 = true;
    }
    public void newAbility2()
    {
        ability2 = true;
    }
    public void newAbility3()
    {
        ability3 = true;
    }
    public void newAbility4()
    {
        ability4 = true;
    }
    public void newAbility5()
    {
        ability5 = true;
    }
    private void resetInventory()
    {
        for (int i = 0; i < 5; i++)
        {
            toggles[i].gameObject.SetActive(false);
        }
    }
    public void changethrow(InputAction.CallbackContext context)
    {
        var itemNR = context.control.name.ToString().TrimStart(); ;
        if(itemNR == "1")
        {
            if (ability1 == true)
            {
                resetInventory();
                toggles[0].gameObject.SetActive(true);
            }
        }
        else if(itemNR == "2")
        {
            if (ability2 == true)
            {
                resetInventory();
                toggles[1].gameObject.SetActive(true);
            }
        }
        else if(itemNR == "3")
        {
            if (ability3 == true)
            {
                resetInventory();
                toggles[2].gameObject.SetActive(true);
            }
        }
        else if(itemNR == "4")
        {
            if (ability4 == true)
            {
                resetInventory();
                toggles[3].gameObject.SetActive(true);
            }
        }
        else
        {
            if (ability5 == true)
            {
                resetInventory();
                toggles[4].gameObject.SetActive(true);
            }
        }
    }

    
}