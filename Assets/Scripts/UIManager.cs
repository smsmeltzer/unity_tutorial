using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private int _score;
    void Start()
    {
        _scoreText.text = "Coins Collected: " + 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int pts)
    {
        _score += pts;
        _scoreText.text = "Coins Collected: " + _score.ToString();
    }

    public int getScore()
    {
        return _score;
    }
}
