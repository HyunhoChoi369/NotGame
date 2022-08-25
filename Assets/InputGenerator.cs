using UnityEngine;

public class InputGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Circle;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = cam.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            var go = Instantiate(Circle, pos, Quaternion.identity);
            go.GetComponent<SpriteRenderer>().color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
        }
    }
}
