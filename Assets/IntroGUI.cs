using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class IntroGUI : MonoBehaviour {

	public Text TextField;

	public static event Action<MainController.GameState> ChangeGameState;

	void OnEnable () {
		Dialoguer.Initialize();
		bindDialogueEvents();
		Dialoguer.StartDialogue(DialoguerDialogues.Intro);
	}

	public void OnButtonClick() {
		Dialoguer.ContinueDialogue();
	}
	
	private void bindDialogueEvents() {
		Dialoguer.events.onStarted += OnStarted;
		Dialoguer.events.onTextPhase += OnTextPhase;
		Dialoguer.events.onEnded += OnEnded;
	}

	private void OnStarted() {
	}

	private void OnTextPhase(DialoguerTextData data) {
		TextField.text = data.text;
	}

	private void OnEnded() {
		if (ChangeGameState != null) {
			ChangeGameState(MainController.GameState.Main);
		}
	}
}
