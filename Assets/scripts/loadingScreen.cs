using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLoadingScreenOnClick : MonoBehaviour
{
    public string loadingScreenScene; // Название сцены загрузочного экрана

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Проверяем, была ли нажата левая кнопка мыши
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("enemy")) // Проверяем, является ли объект мобом
                {
                    // Загрузка сцены загрузочного экрана
                    SceneManager.LoadScene(2);
                }
            }
        }
    }
}