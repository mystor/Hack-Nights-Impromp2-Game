using UnityEngine;
using System.Collections.Generic;

public class ScoreKeeper : MonoBehaviour {

	private HashSet<Target> targets = new HashSet<Target>();

	public void Add(Target target) {
		targets.Add(target);
	}

	public void Remove(Target target) {
		targets.Remove(target);
	}

	void Update() {
		GUIText text = GetComponent<GUIText>();
		text.text = targets.Count + "/10";
	}
}
