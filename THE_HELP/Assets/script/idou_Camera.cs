using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SocialPlatforms;

public class idou_Camera : MonoBehaviour
{
    /*
        WASD:前後左右の移動
         QE:上昇・下降
         右ドラッグ:カメラの回転
         左ドラッグ:前後左右の移動

         */
    //カメラ移動
    [SerializeField, Range(0.1f, 10.0f)]
    private float _positionStep = 2.0f;

    //マウス感度
    [SerializeField, Range(30.0f, 150.0f)]
    private float _mouseSensitive = 90.0f;

    //カメラ操作の有無
    private bool _cameraMoveActive;

    //カメラのtransform
    private Transform _camTransform;

    //マウスの始点
    private Vector3 _startMousePos;

    //カメラの回転の始点情報
    private Vector3 _presentCamRotation;
    private Vector3 _presentCamPos;

    //初期状態 Rotation
    private Quaternion _initialCamRotation;

    //UIメッセージの表示
    private bool _uiMessageActiv;

    // Start is called before the first frame update
    void Start()
    {
        _camTransform = this.gameObject.transform;

        //初期回転の保存
        _initialCamRotation = this.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        CamControlIsActive();
        //カメラ操作の有効無効

    }
    public void CamControlIsActive()
    {
        if(Input.GetkeyDown(KeyCode.o))
        {
            _cameraMoveActive = !_cameraMoveActive;

            if(_uiMessageActiv == false)
            {

            }
        }
        
    }

}
