using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{

    private Dictionary<int, int> D_inventory = new Dictionary<int, int>();

    /// <summary>
    /// Add one of item "id" to the inventory
    /// </summary>
    /// <param name="id"></param>
    public void AddToInventory(int id)
    {
        if (D_inventory.ContainsKey(id))
            D_inventory[id] += 1;
        else
            D_inventory.Add(id, 1);
    }
    /// <summary>
    /// Add "amount" of item "id" to the inventory
    /// </summary>
    /// <param name="id"></param>
    /// <param name="amount"></param>
    public void AddToInventory(int id, int amount)
    {
        if (D_inventory.ContainsKey(id))
            D_inventory[id] += amount;
        else
            D_inventory.Add(id, amount);
    }

    /// <summary>
    /// Remove 1 of item "id" from the inventory if there is one
    /// </summary>
    /// <param name="id"></param>
    public void RemoveFromInventory(int id)
    {
        if (D_inventory.ContainsKey(id))
        {
            D_inventory[id] -= 1;
            if (D_inventory[id] <= 0)
                D_inventory.Remove(id);
        }
    }
    /// <summary>
    /// Remove "amount" of item "id" from the inventory if there is at least 1
    /// </summary>
    /// <param name="id"></param>
    /// <param name="amount"></param>
    public void RemoveFromInventory(int id, int amount)
    {
        if (D_inventory.ContainsKey(id))
        {
            D_inventory[id] -= amount;
            if (D_inventory[id] <= 0)
                D_inventory.Remove(id);
        }
    }

    /// <summary>
    /// Check if there is "amount" of item "id" in the inventory
    /// </summary>
    /// <param name="id"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    public bool QueryItemCountInInventory(int id, int amount)
    {
        if (D_inventory.ContainsKey(id))
            return D_inventory[id] >= amount;
        return false;
    }

    /// <summary>
    /// Clears the inventory
    /// </summary>
    public void ClearInventory()
    {
        D_inventory = new Dictionary<int, int>();
    }

    /// <summary>
    /// Get a copy of the inventory
    /// </summary>
    /// <returns></returns>
    public Dictionary<int, int> GetInventory()
    {
        return D_inventory;
    }

    /// <summary>
    /// Get a count of how many of item "id" is in the inventory. 
    /// "-1" means that item isn't in the inventory
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public int GetItemCount(int id)
    {
        if (D_inventory.ContainsKey(id))
            return D_inventory[id];
        return 0;
    }

}
