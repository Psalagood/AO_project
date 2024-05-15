using UnityEngine;

public class GridRenderer : MonoBehaviour
{
    public int gridSize = 3; // ������ �����
    public float gridSpacing = 1f; // ���������� ����� ��������
    public float distanceBetweenGrids = 5f; // ���������� ����� �������
    public GameObject gridPrefab; // ������ �����

    private void Start()
    {
        CreateGrid(Vector3.zero); // �������� ������ �����
        CreateGrid(new Vector3(0f, 0f, distanceBetweenGrids)); // �������� ������ ����� � ������ ����������
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