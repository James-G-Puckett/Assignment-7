using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class WordGenerator : MonoBehaviour {
    
    private static string[] wordList = File.ReadAllLines("Assets/Resources/WordList.txt");

    public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
