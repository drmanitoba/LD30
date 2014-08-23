using UnityEngine;
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
		int idx = 0;

		foreach (KeyValuePair<string, string> pair in resources) {
			string label;

			idx++;

			label = string.Format("{0}: {1}", pair.Key, pair.Value);

			Transform listItem = (Transform) Instantiate(ResourceItem, Vector3.zero, Quaternion.identity);
			listItem.SetParent(this.transform);
			Text text = listItem.gameObject.GetComponent<Text>();
			text.rectTransform.anchoredPosition = new Vector2(.5f, .5f);
			text.rectTransform.Translate(new Vector2(30,  -20 + ((30 * idx) * -1)));

			text.text = label;
		}
	}
}
