using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        // 初期位置
        transform.position = new Vector3(27.5f, 6.7f, 3.9f);

		Sequence testSequence = DOTween.Sequence();
        Vector3[] paths = new [] {
            new Vector3(20f, 10f, 0f),
            new Vector3(9.6f, 1.2f, 2.3f),
            new Vector3(8.6f, 2.1f, 0.4f),
        };
        testSequence.Append(
            transform.DOPath(
                paths,
                5.0f,
                PathType.CatmullRom
            )
        );
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
