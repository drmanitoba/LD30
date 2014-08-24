using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class MainController : MonoBehaviour {

	public Transform TermsCanvas;
	public Alien[] Aliens;
	public GameObject IntroUI;
	public GameObject MainUI;

	public enum GameState {
		Intro,
		Main,
		End
	}

	private GameState currentState;

	private Alien currentAlien;

	// Use this for initialization
	void Start () {
		Dialoguer.Initialize();
		currentState = GameState.Intro;

		IntroGUI.ChangeGameState += HandleChangeGameState;

		IntroUI.SetActive(true);
	}

	void HandleChangeGameState (GameState obj) {
		IntroGUI.ChangeGameState -= HandleChangeGameState;
		IntroUI.SetActive(false);
		MainUI.SetActive(true);
		currentState = obj;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void DisplayTerms() {
		
	}
}