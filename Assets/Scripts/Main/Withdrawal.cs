using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    public GameObject Button;
    public GameObject WithdrawalUI;

    public void OnClickWithdrawal()
    {
        Button.SetActive(false);
        WithdrawalUI.SetActive(true);
    }
}
