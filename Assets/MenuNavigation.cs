using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuNavigation : MonoBehaviour {

	public Color activatedClr,deactivatedClr;
	public Button map,shops;
	public GameObject mapPanel,shopPanel;
	// Use this for initialization
	void Start () {
		OpenShop();
	}

	public void OpenMap(){
		map.image.color=activatedClr;
		shops.image.color=deactivatedClr;
		mapPanel.gameObject.SetActive(true);
		shopPanel.gameObject.SetActive(false);
	}

	public void OpenShop(){
		map.image.color=deactivatedClr;
		shops.image.color=activatedClr;
		mapPanel.gameObject.SetActive(false);
		shopPanel.gameObject.SetActive(true);
	}
	
}
