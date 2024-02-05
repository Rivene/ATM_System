using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deposit_10000 : MonoBehaviour
{
    public Text Cash;
    public Text Balance;
    int CashNum;
    int BalanceNum;

    public void OnClick10000()
    {
        CashNum = int.Parse(Cash.text);
        CashNum -= 10000;
        Cash.text = CashNum.ToString();

        BalanceNum = int.Parse(Balance.text);
        BalanceNum += 10000;
        Balance.text = BalanceNum.ToString();
    }
}
