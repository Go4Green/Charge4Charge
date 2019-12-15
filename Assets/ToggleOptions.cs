using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOptions : MonoBehaviour
{

    public GameObject filters, search, favorite;

    private bool areActive = true;
    // Use this for initialization
    void Start()
    {
       ToggleOptionsBtn();
    }

    public void ToggleOptionsBtn()
    {
		 areActive = !areActive;
        filters.SetActive(areActive);
        search.SetActive(areActive);
        favorite.SetActive(areActive);
    }


}
