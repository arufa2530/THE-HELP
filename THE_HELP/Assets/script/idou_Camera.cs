using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SocialPlatforms;


/*
public class idou_Camera : MonoBehaviour
{
    /*
        WASD:前後左右の移動
         QE:上昇・下降
         右ドラッグ:カメラの回転
         左ドラッグ:前後左右の移動

         
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
        CameraOn();
    }

    void CameraOn()
    {
        if(_cameraMoveActive)
        {
            ResetCameraRotation();
            CameraRotationMouseControl();
            CameraSlideMouseControl();
            CameraPositionKeyControl();
        }
    }

    //カメラ操作の有無
    public void CamControlIsActive()
    {
        if(Input.GetKeyDown("q"))
        {
            Debug.Log("QChara");
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            _cameraMoveActive = !_cameraMoveActive;

            if(_uiMessageActiv == false)
            {
                StartCoroutine(DisplayUiMessage());
            }
            Debug.Log("CamControl : " + _cameraMoveActive);
        }
        
    }

    //回転の初期化
    private void ResetCameraRotation()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            this.gameObject.transform.rotation = _initialCamRotation;
            Debug.Log("Cam Rotate : " + _initialCamRotation.ToString());
        }
    }
    
    //カメラの回転（マウス）
    private void CameraRotationMouseControl()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _startMousePos = Input.mousePosition;
            _presentCamRotation.x = _camTransform.transform.eulerAngles.x;
            _presentCamRotation.y = _camTransform.transform.eulerAngles.y;
        }

        if(Input.GetMouseButton(0))
        {
            //(移動開始座標　-　マウスの現在地) /　解像度で初期化
            float x = (_startMousePos.x - Input.mousePosition.x) / Screen.width;
            float y = (_startMousePos.y - Input.mousePosition.y) / Screen.height;
        }
    }

}
*/