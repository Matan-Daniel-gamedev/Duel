using UnityEngine;
using TMPro;
using System;
/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    //[SerializeField] string triggeringTag;
    //[SerializeField] NumberField scoreField;
    //[SerializeField] int pointsToAdd;
    TextMeshProUGUI P1;
    TextMeshProUGUI P2;
    void Start () {
        P1 = GameObject.Find("P1 Lives Counter").GetComponent<TextMeshProUGUI>();
        P2 = GameObject.Find("P2 Lives Counter").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // if (other.tag == triggeringTag && scoreField!=null) {
        //     scoreField.AddNumber(pointsToAdd);
        // }
        if(other.tag == "P1"){
            P1.text = (Convert.ToInt32(P1.text)-1).ToString();
        }else if(other.tag == "P2"){
            P2.text = (Convert.ToInt32(P2.text)-1).ToString();
        }
    }
}
