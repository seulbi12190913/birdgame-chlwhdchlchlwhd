using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameovermanager : MonoBehaviour
{
    public TextMeshProUGUI scorelabel;

    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);

        scorelabel.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAgainPressed()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void QuitPressed()
    {
        Application.Quit();
    }
   

}
