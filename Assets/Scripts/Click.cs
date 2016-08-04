using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text kpc;
    public UnityEngine.UI.Text kittyDisplay;
    public float kitties = 0.00f;
    public int kittiesPerClick = 1;

    void Update()
    {
        kittyDisplay.text = "Kitties: " + kitties;
        kpc.text = "Kitties Per Click: " + kittiesPerClick;

        if (kittiesPerClick == 100)
        {
            ShowAdPlacement();
        }

    }

    public void Clicked()
    {
        kitties += kittiesPerClick;
    }

    void ShowAdPlacement()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

}
