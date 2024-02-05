using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashBalance : MonoBehaviour
{
    public Text Cash;
    public Text Balance;

    private void Start()
    {
        Cash.text = "100000";
        Balance.text = "50000";
    }
}
