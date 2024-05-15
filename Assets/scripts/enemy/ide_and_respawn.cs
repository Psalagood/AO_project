using UnityEngine;
using System.Collections;

public class ObjectBehavior : MonoBehaviour
{
    public float speed = 2f;
    public float radius = 10f;  

    private void Update()
    {
        Vector3 randomDirection = Random.insideUnitCircle.normalized * speed;
        transform.position += new Vector3(randomDirection.x, 0f, randomDirection.y) * Time.deltaTime;
        transform.position = Vector3.ClampMagnitude(transform.position, radius);
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        StartCoroutine(EnableObject());
    }

    private IEnumerator EnableObject()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(true);
    }
}