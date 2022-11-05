using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text scoreKiri;
    public Text scoreKanan;

    public ScoreManager manager;
    
    private void Update() {
        scoreKiri.text = manager.leftScore.ToString();
        scoreKanan.text = manager.rightScore.ToString();
    }
}
