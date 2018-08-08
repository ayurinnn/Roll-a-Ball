using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
  // トリガーとの接触時に呼ばれるコールバック
  private void OnTriggerEnter(Collider hit)
  {
    // 接触対象がPlayerタグ持ちなら消滅
    if (hit.CompareTag("Player"))
    {
      // このコンポーネントを持つGameObjectを破棄する
      Destroy(gameObject);
    }
  }
  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
