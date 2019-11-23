using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour {

    public static int Score = 0;
    public static int MissedScore;
    public static int highScore = 0;

	public Text text;
	public float fallSpeed = 1f;

    public AudioClip cubeSound;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        //Score = 0;
        //MissedScore = 0;
    }
    private void Start()
    {
        
    }
    public void SetWord (string word)
	{
		text.text = word;
        text.color = KeepData.ColorOfWord;

        //audioSource.PlayOneShot(cubeSound);
    }

	public void RemoveLetter ()
	{
        audioSource.PlayOneShot(cubeSound);
        text.text = text.text.Remove(0, 1);
		text.color = Color.red;
        

    }

	public void RemoveWord ()
	{
        Score++;
        if (Score > highScore)
        {
            highScore = Score;
        }
		Destroy(gameObject);
        //Debug.Log(Score);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "barrier")
        {
            MissedScore++;
            //SceneManager.LoadScene("Exit");

        }
    }
    
    private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime*KeepData.WordSpeedMultiplier, 0f);
        
	}

}
