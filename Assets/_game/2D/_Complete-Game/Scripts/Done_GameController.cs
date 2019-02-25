using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Done_GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public int waveCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text roundText;
    public Text gameOverText;

    private bool gameOver;
    private bool restart;
    private int round;

    private bool quit = false;

    void Start()
    {
        gameOver = false;
        restart = false;
        gameOverText.text = "";
        round = waveCount;
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        for (int j = 0; j < waveCount; j++)
        {
            UpdateRound(j);
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                //Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
        SceneManager.LoadScene(1);
    }

    void UpdateRound(int r)
    {
        roundText.text = "Round: (" + r + "/" + round + ")";
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
        StartCoroutine(DelayLoadLevel(3));

    }

    bool loadingStarted = false;
    float secondsLeft = 0;

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        SceneManager.LoadScene(0);
    }

}