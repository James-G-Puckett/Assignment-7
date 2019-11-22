using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

    public static int Score;
	public Text text;
	public float fallSpeed = 1f;

    public AudioClip cubeSound;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void SetWord (string word)
	{
		text.text = word;
        text.color = KeepData.ColorOfWord;

        audioSource.PlayOneShot(cubeSound);
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
		Destroy(gameObject);
        //Debug.Log(Score);
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime*KeepData.WordSpeedMultiplier, 0f);
	}

}
