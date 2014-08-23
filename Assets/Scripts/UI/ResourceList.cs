﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ResourceList : MonoBehaviour {

	public Transform ResourceItem;

	private ResourceManager manager;

	// Use this for initialization
	void Start () {
		manager = new ResourceManager();

		BuildList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void BuildList() {
		Dictionary<string, string> resources = manager.GetResourceList();

		foreach (KeyValuePair<string, string> pair in resources) {
			string label;

			label = string.Format("{0}: {1}", pair.Key, pair.Value);

			Transform listItem = (Transform) Instantiate(ResourceItem, Vector3.one, Quaternion.identity);
			listItem.parent = this.transform;
			Text text = listItem.gameObject.GetComponent<Text>();

			text.text = label;
		}
	}
}
