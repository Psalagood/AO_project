using UnityEngine;

public class GridRenderer : MonoBehaviour
{
    public int gridSize = 3; // Размер сетки
    public float gridSpacing = 1f; // Расстояние между клетками
    public float distanceBetweenGrids = 5f; // Расстояние между сетками
    public GameObject gridPrefab; // Префаб сетки

    private void Start()
    {
        CreateGrid(Vector3.zero); // Создание первой сетки
        CreateGrid(new Vector3(0f, 0f, distanceBetweenGrids)); // Создание второй сетки с учетом расстояния
    }

    private void CreateGrid(Vector3 offset)
    {
        for (int x = 0; x < gridSize; x++)
        {
            for (int z = 0; z < gridSize; z++)
            {
                Vector3 position = new Vector3(x * gridSpacing, 0f, z * gridSpacing) + offset;
                Instantiate(gridPrefab, position, Quaternion.identity);
            }
        }
    }
}