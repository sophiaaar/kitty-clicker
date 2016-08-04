using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count;
    public int clickPower;
    public string itemName;
    private float _newCost;

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickPower;
    }

    public void PurchasedUpgrade()
    {
        if (click.kitties >= cost)
        {
            click.kitties -= cost;
            count += 1;
            click.kittiesPerClick += clickPower;
            cost = Mathf.Round(cost * 1.15f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
        }
    }
	
}
