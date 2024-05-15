using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLoadingScreenOnClick : MonoBehaviour
{
    public string loadingScreenScene; // �������� ����� ������������ ������

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���������, ���� �� ������ ����� ������ ����
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("enemy")) // ���������, �������� �� ������ �����
                {
                    // �������� ����� ������������ ������
                    SceneManager.LoadScene(2);
                }
            }
        }
    }
}