using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpBtn : MonoBehaviour
{
    public GameObject PopUp;

    public void OnClickPopUpBtn()
    {
        PopUp.SetActive(false);
    }
}
