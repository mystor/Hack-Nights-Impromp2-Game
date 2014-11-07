using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public Texture activated_texture;
	public Texture deactivated_texture;
	public ScoreKeeper scoreKeeper;

	private int activated = 0;

	void Start() {
		renderer.material.SetTexture("_MainTex", deactivated_texture);
	}

	public void Activate() {
		activated++;
		if (activated > 0) {
			renderer.material.SetTexture("_MainTex", activated_texture);
			scoreKeeper.Add(this);
		}
	}

	public void Deactivate() {
		activated--;
		if (activated < 1) {
			renderer.material.SetTexture("_MainTex", deactivated_texture);
			scoreKeeper.Remove(this);
		}
	}

}
