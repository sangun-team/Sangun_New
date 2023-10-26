using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    // 3��Ī ���� �� ���
    public GameObject mainCam;
    // 3��Ī ���� �� ���
    public GameObject subCam;

    public GameObject target; // ī�޶� ����ٴ� Ÿ��

    public float offSetX = 0f; // ī�޶��� x��ǥ
    public float offSetY = 10f; // ī�޶��� y��ǥ
    public float offsetZ = -10; // ī�޶��� z��ǥ

    //public float rotSensitive = 3f; // ī�޶� ȸ�� ����
    //public float rotMin = 10f; // ī�޶� ȸ�� �ּ� ����
    //public float rotMax = 80; // ī�޶� ȸ�� �ִ� ����
    //public float rotSmoothTime = 0.15f; // ī�޶� ȸ���ϴµ� �ɸ��� �ð�

    //public Vector3 targetRot; // Ÿ�� ȸ�� ����
    //public Vector3 currentVel; // ���� ����

    //public float Yaxis; // ���콺 �¿� ������ (ī�޶� Y��) 
    //public float Xaxis; // ���콺 ���� ������ (ī�޶� X��)

    public float CameraSpeed = 10f; // ī�޶��� �ӵ�
    Vector3 TargetPos; // Ÿ���� ��ġ

    private void Start()
    {
        mainCam.SetActive(true);
        subCam.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        // Ÿ���� x,y,z ��ǥ�� ī�޶��� ��ǥ�� ���Ͽ� ī�޶��� ��ġ�� ����
        TargetPos = new Vector3(target.transform.position.x + offSetX, target.transform.position.y + offSetY, target.transform.position.z + offsetZ);
        // ī�޶��� �������� �ε巴�� �ϴ� �Լ�
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
        //// ���콺 �¿� ������ �Է� �޾Ƽ� ī�޶� Y�� ȸ��
        //Yaxis = Yaxis + Input.GetAxis("Mouse X") * rotSensitive;
        //// ���콺 ���� ������ �Է� �޾Ƽ� ī�޶� X�� ȸ��
        //Xaxis = Xaxis + Input.GetAxis("Mouse Y") * rotSensitive;

        //// X�� ȸ���� �Ѱ�ġ�� ���� �ʰ� �������ֱ�
        //Xaxis = Mathf.Clamp(Xaxis,rotMin,rotMax);

        //// SmoothDamp �Լ��� ���� �ε巯�� ī�޶� ȸ��
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