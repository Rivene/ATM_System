using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawalInput : MonoBehaviour
{
    public Text Cash;
    public Text Balance;
    public InputField Input;
    public GameObject PopUp;
    int CashNum;
    int BalanceNum;
    int InputNum;

    public void OnClickInput()
    {
        if (!int.TryParse(Input.text, out InputNum))
        {
            Input.text = "";
            return;
        }

        Input.text = "";

        if (int.Parse(Balance.text) < InputNum)
        {
            PopUp.SetActive(true);
            return;
        }

        CashNum = int.Parse(Cash.text);
        CashNum += InputNum;
        Cash.text = CashNum.ToString();

        BalanceNum = int.Parse(Balance.text);
        BalanceNum -= InputNum;
        Balance.text = BalanceNum.ToString();
    }
}
