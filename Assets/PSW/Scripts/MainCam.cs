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