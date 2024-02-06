using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositNum : MonoBehaviour
{
    public Text Cash;
    public Text Balance;
    public GameObject PopUp;
    int CashNum;
    int BalanceNum;

    public void OnClick10000()
    {
        if (int.Parse(Cash.text) < 10000)
        {
            PopUp.SetActive(true);
            return;
        }

        CashNum = int.Parse(Cash.text);
        CashNum -= 10000;
        Cash.text = CashNum.ToString();

        BalanceNum = int.Parse(Balance.text);
        BalanceNum += 10000;
        Balance.text = BalanceNum.ToString();
    }

    public void OnClick30000()
    {
        if (int.Parse(Cash.text) < 30000)
        {
            PopUp.SetActive(true);
            return;
        }

        CashNum = int.Parse(Cash.text);
        CashNum -= 30000;
        Cash.text = CashNum.ToString();

        BalanceNum = int.Parse(Balance.text);
        BalanceNum += 30000;
        Balance.text = BalanceNum.ToString();
    }

    public void OnClick50000()
    {
        if (int.Parse(Cash.text) < 50000)
        {
            PopUp.SetActive(true);
            return;
        }

        CashNum = int.Parse(Cash.text);
        CashNum -= 50000;
        Cash.text = CashNum.ToString();

        BalanceNum = int.Parse(Balance.text);
        BalanceNum += 50000;
        Balance.text = BalanceNum.ToString();
    }
}
