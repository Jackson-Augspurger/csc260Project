﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    [Range(0.1f,10f)] [SerializeField] float gameSpeed = 1f;

    [SerializeField] int pointsPerBlockDestroyed = 83;

    [SerializeField] int currentScore = 0;

	// Update is called once per frame
	void Update () {
        Time.timeScale = gameSpeed;
	}

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}
