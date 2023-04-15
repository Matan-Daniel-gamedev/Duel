using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
/**
* This component increases a given "score" field whenever it is triggered.
*/
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    
    TextMeshProUGUI P1;
    TextMeshProUGUI P2;
    TextMeshProUGUI WinnerTitle;
    TextMeshProUGUI current;

    GameObject destroyed;
    GameObject PlayAgain;
    void Start ()
    {
        P1 = GameObject.Find("P1 Lives Counter").GetComponent<TextMeshProUGUI>();
        P2 = GameObject.Find("P2 Lives Counter").GetComponent<TextMeshProUGUI>();
        WinnerTitle = GameObject.Find("Winner Title").GetComponent<TextMeshProUGUI>();

        PlayAgain = GameObject.Find("Play Again Button");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "P1")
        {
            current = P1;
        }else if(other.tag == "P2"){
            current = P2;
        }

        current.text = (Convert.ToInt32(current.text) - 1).ToString();
        if(current.text == "0")
        {
            String Winner;
            if (other.tag == "P1"){
                Winner = "P2";
            }
            else{
                Winner = "P1";
            }

            P1.text = "";
            P2.text = "";

            WinnerTitle.text = $"{Winner} is the Winner!";
            destroyed = other.gameObject;
            destroyed.SetActive(false);

            PlayAgain.GetComponent<Button>().interactable = true;
            PlayAgain.GetComponentInChildren<TextMeshProUGUI>().text = "Play Again";
        }
    }

    
}
