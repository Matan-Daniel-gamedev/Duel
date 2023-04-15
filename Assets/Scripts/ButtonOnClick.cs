using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOnClick : MonoBehaviour
{
    TextMeshProUGUI P1Text;
    TextMeshProUGUI P2Text;
    TextMeshProUGUI WinnerTitle;
    GameObject P1;
    GameObject P2;

    void Start()
    {
        P1 = GameObject.Find("P1");
        P2 = GameObject.Find("P2");

        P1Text = GameObject.Find("P1 Lives Counter").GetComponent<TextMeshProUGUI>();
        P2Text = GameObject.Find("P2 Lives Counter").GetComponent<TextMeshProUGUI>();
        WinnerTitle = GameObject.Find("Winner Title").GetComponent<TextMeshProUGUI>();
    }

    public void resetGame()
    {
        P1Text.text = "3";
        P2Text.text = "3";
        WinnerTitle.text = "";
        P1.SetActive(true);
        P2.SetActive(true);

        Vector3 prevP1 = P1.GetComponent<Transform>().position;
        P1.GetComponent<Transform>().position = new Vector3(prevP1.x, 0, prevP1.z);

        Vector3 prevP2 = P2.GetComponent<Transform>().position;
        P2.GetComponent<Transform>().position = new Vector3(prevP2.x, 0, prevP2.z);

        this.gameObject.GetComponent<Button>().interactable = false;
        this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "";
    }
}
