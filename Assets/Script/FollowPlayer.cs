using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
  // ターゲットへの参照
  public Transform target;
  // 相対座標
  private Vector3 offset;

  // 初期設定
  void Start () {
    // 自分自身とtargetとの相対距離を求める
    offset = GetComponent<Transform>().position - target.position;
	}
	
	// 1フレームごとに更新
	void Update () {
    // 自分の座標にtargetの座標に相対座標を足した値を代入する
    GetComponent<Transform>().position = target.position + offset;
	}
}
