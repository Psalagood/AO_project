using UnityEngine;
using UnityEngine.UI;

public class InfoWindow : MonoBehaviour
{
    public GameObject BuildWall;  // —сылка на окно, которое нужно вывести

    public void ShowWindow()
    {
        BuildWall.SetActive(true);
    }

    public void HideWindow()
    {
        BuildWall.SetActive(false); 
    }
}