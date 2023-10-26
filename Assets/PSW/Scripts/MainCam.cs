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