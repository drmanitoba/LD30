using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Alien : DisplayObject {

	public List<ResourceManager.Resources> ResourcesRequired;
	public DialoguerDialogues Dialogue;

	protected override void Initialize () {
		base.Initialize ();
		Dialoguer.Initialize();
	}

	public void Start() {
		Dialoguer.StartDialogue(Dialogue);
	}

	public override void Update () {
	}
}
