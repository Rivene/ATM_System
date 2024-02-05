using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deposit : MonoBehaviour
{
    public GameObject Button;
    public GameObject DepositUI;

    public void OnClickDeposit()
    {
        Button.SetActive(false);
        DepositUI.SetActive(true);
    }
}
