using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {	
	}

  public UnityEngine.UI.Text scoreLabel;
  public GameObject winnerLabelObject;

	// Update is called once per frame
	public void Update () {
    int count = GameObject.FindGameObjectsWithTag("Item").Length;
    scoreLabel.text = count.ToString();

    // クリア時処理（Itemを全て回収）
    if (count == 0)
    {
      winnerLabelObject.SetActive(true);
    } 
  }
}
