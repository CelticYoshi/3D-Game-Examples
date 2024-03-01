using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public int _amountToOpenTheDoor = 39;
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
        scoreText.text = "Sodas: " + _coinCount.ToString(); 
    }

    public void UpdateCoinCount()
    {
        _coinCount++;
        DisplayCoinCount();

        if(_coinCount >= _amountToOpenTheDoor)
        {
            GameObject.Find("Door").GetComponent<Doors>().DoorCanBeOpened();
        }
    }
}
