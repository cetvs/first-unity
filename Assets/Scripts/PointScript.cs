using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour
{
    [SerializeField]
    private Text pointText;
    [SerializeField] 
    private PlayerScript script;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + script.score.ToString();
    }
}
