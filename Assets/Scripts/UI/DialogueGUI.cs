using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class DialogueGUI : MonoBehaviour {

	public Text textBox;
	public Transform ButtonPanel;
	public GameObject ButtonPrefab;

	// Use this for initialization
	void Start () {
		bindDialogueEvents();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonClick(int buttonIdx) {
		Dialoguer.ContinueDialogue(buttonIdx);
	}

	private void bindDialogueEvents() {
		Dialoguer.events.onStarted += OnStarted;
		Dialoguer.events.onTextPhase += OnTextPhase;
	}

	private void OnStarted() {
	}

	private void OnTextPhase(DialoguerTextData data) {
		textBox.text = data.text;

		if (data.choices != null) {
			foreach (string choice in data.choices) {
				GameObject temp = (GameObject) Instantiate(ButtonPrefab);
				temp.transform.SetParent(ButtonPanel.transform);

				Text label = temp.transform.GetChild(0).GetComponent<Text>();
				label.text = choice;

				Button button = temp.GetComponent<Button>();
				int idx = Array.IndexOf(data.choices, choice);
				button.onClick.AddListener(delegate { OnButtonClick(idx); });
			}
		} else {
			Transform[] children = ButtonPanel.gameObject.GetComponentsInChildren<Transform>();

			foreach (Transform child in children) {
				Destroy (child.gameObject);
			}
		}
	}
}
