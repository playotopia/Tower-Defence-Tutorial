using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoneyUi : MonoBehaviour {

    public Text moneyText;


	// Update is called once per frame
	void Update () {
        moneyText.text = "$" + PlayerStats.Money.ToString();
	}
}
