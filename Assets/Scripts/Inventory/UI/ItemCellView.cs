﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemCellView : MonoBehaviour
{
    // Item visual representation
    public Text Name;
    public Text Attack;
    public Text Range;
    public Text Defense;
    public Text Durability;
    public Text Cost;

    public void SetData(ItemData data)
    {
        this.gameObject.name = data.Name;

        this.Name.text = data.Name;
        this.Attack.text = data.Attack.ToString();
        this.Range.text = data.Range.ToString();
        this.Defense.text = data.Defense.ToString();
        this.Durability.text = data.Durability.ToString();
        this.Cost.text = data.Cost.ToString();
    }
}
