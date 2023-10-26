using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    // 3인칭 시점 뒷 모습
    public GameObject mainCam;
    // 3인칭 시점 앞 모습
    public GameObject subCam;

    public GameObject target; // 카메라가 따라다닐 타겟

    public float offSetX = 0f; // 카메라의 x좌표
    public float offSetY = 10f; // 카메라의 y좌표
    public float offsetZ = -10; // 카메라의 z좌표

    //public float rotSensitive = 3f; // 카메라 회전 감도
    //public float rotMin = 10f; // 카메라 회전 최소 각도
    //public float rotMax = 80; // 카메라 회전 최대 각도
    //public float rotSmoothTime = 0.15f; // 카메라 회전하는데 걸리는 시간

    //public Vector3 targetRot; // 타겟 회전 방향
    //public Vector3 currentVel; // 현재 방향

    //public float Yaxis; // 마우스 좌우 움직임 (카메라 Y축) 
    //public float Xaxis; // 마우스 상하 움직임 (카메라 X축)

    public float CameraSpeed = 10f; // 카메라의 속도
    Vector3 TargetPos; // 타겟의 위치

    private void Start()
    {
        mainCam.SetActive(true);
        subCam.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        // 타겟의 x,y,z 좌표에 카메라의 좌표를 더하여 카메라의 위치를 결정
        TargetPos = new Vector3(target.transform.position.x + offSetX, target.transform.position.y + offSetY, target.transform.position.z + offsetZ);
        // 카메라의 움직임을 부드럽게 하는 함수
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
        //// 마우스 좌우 움직임 입력 받아서 카메라 Y축 회전
        //Yaxis = Yaxis + Input.GetAxis("Mouse X") * rotSensitive;
        //// 마우스 상하 움직임 입력 받아서 카메라 X축 회전
        //Xaxis = Xaxis + Input.GetAxis("Mouse Y") * rotSensitive;

        //// X축 회전이 한계치를 넘지 않게 제한해주기
        //Xaxis = Mathf.Clamp(Xaxis,rotMin,rotMax);

        //// SmoothDamp 함수를 통해 부드러운 카메라 회전
        //targetRot = Vector3.SmoothDamp(targetRot, new Vector3(rotMin, rotMax), ref currentVel, rotSmoothTime);

        //this.transform.eulerAngles = targetRot;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mainCam.SetActive(false);
            subCam.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            mainCam.SetActive(true);
            subCam.SetActive(false);
        }
    }
}