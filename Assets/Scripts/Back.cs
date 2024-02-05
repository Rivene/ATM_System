using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject Button;
    public GameObject DepoWithUI;

    public void OnClickBack()
    {
        DepoWithUI.SetActive(false);
        Button.SetActive(true);
    }
}
