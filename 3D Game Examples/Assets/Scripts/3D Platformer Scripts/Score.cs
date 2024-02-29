using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIComponents : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public int _coinCount = 0;

    // Start is called before the first frame update
    void Start()
    {
       DisplayCoinCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayCoinCount()
    {
        scoreText.text = "Sodas: " + score.ToString(); 
    }

    public void UpdateCoinCount()
    {
        _coinCount++;
        DisplayCoinCount();
    }
}
