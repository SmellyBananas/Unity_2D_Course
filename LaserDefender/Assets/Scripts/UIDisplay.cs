using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [Header("Heath")]
    [SerializeField] Slider heathSlider;
    [SerializeField] Heath playerHeath;


    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKepper; 

    void Awake()
    {
        scoreKepper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        heathSlider.maxValue = playerHeath.GetHeath();
    }

    void Update()
    {
        heathSlider.value = playerHeath.GetHeath();
        scoreText.text = scoreKepper.GetScore().ToString("000000000");
    }
}
