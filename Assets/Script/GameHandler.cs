using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public static GameHandler gameHandler;
    public GameObject spawners, pauseMenu;
    [SerializeField] public int hiScore = 0;
    [SerializeField] public int currentScore = 0;
    [SerializeField] Text currentScoreCounter;
    [SerializeField] Text hiScoreCounter;

    public float timeLeft = 3.0f;
    [SerializeField] Text startText; // used for showing countdown from 3, 2, 1 
    public GameObject startingPlatform;

    // Start is called before the first frame update
    void Start()
    {
        if (gameHandler == null)
        {
            gameHandler = this;
        }
        else
        {
            Destroy(this);
            Debug.LogWarning("Second GameHandler");
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            startText.gameObject.SetActive(false);
            //Do something useful or Load a new game scene depending on your use-case
            startingPlatform.SetActive(false);
            spawners.SetActive(true);
        }
    }
    public void AddScore()
    {
        currentScore += 10;
        currentScoreCounter.text = "" + currentScore;
        PlayerPrefs.SetInt("Score", currentScore);
    }
    public void MinusScore()
    {
        currentScore -= 1;
        currentScoreCounter.text = "" + currentScore;
        PlayerPrefs.SetInt("Score", currentScore);
    }
    public void HiScore()
    {
        if (PlayerPrefs.GetInt("HiScore", 0) <= currentScore)
        {
            PlayerPrefs.SetInt("HiScore", currentScore);
        }
        
        hiScoreCounter.text = "Hi-Score " + PlayerPrefs.GetInt("HiScore");
    }
    public void Buttons()
    {
        pauseMenu.SetActive(true);
        Debug.Log("Buttons set active?");
    }
    public void ChangeSceneViaIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void FPSToggle(bool FPSlimited)
    {
        if (FPSlimited == true)
        {
            Application.targetFrameRate = 60;
        }
    }
    public void ExitTheGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit(); //quits game within Unity as well
    }
}
