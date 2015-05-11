using UnityEngine;
using System.Collections;
using System.Linq;

public class RandomBlocksGenerator : MonoBehaviour {
  public float minRadius;
  public float maxRadius;
  public int numberOfBlocks;
  public float size;
  public GameObject Popcorn;
  public GameObject Popcorn1;
  public GameObject Popcorn2;

  private void Reset()
  {
    if (maxRadius < minRadius)
      return;

    GameObject box = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    box.transform.parent = transform;
    box.transform.localScale = Vector3.one * (maxRadius + 0.5f ) * 2.0f;
    box.transform.localPosition = Vector3.zero;

    Mesh boxMesh = box.GetComponent<MeshFilter>().mesh;
    boxMesh.triangles = boxMesh.triangles.Reverse().ToArray();
    boxMesh.RecalculateNormals();
    box.GetComponent<SphereCollider>().enabled = false;
    Destroy(box.GetComponent<SphereCollider>());
    box.AddComponent<MeshCollider>();
    box.GetComponent<Renderer>().enabled = false;

    for (int i = 0; i < numberOfBlocks; ++i)
    {
      float radius = Random.Range(minRadius, maxRadius);
      float theta = Random.Range(0.0f, 2 * Mathf.PI);
      float phi = Random.Range(0.0f, 2 * Mathf.PI);

      Vector3 position = new Vector3(
        radius * Mathf.Sin(theta) * Mathf.Cos(phi),
        radius * Mathf.Sin(theta) * Mathf.Sin(phi),
        radius * Mathf.Cos(theta)
        );

      GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
      sphere.transform.parent = transform;
      sphere.transform.rotation = Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
      sphere.transform.localScale = Vector3.one * size;
      sphere.transform.localPosition = position;
      sphere.AddComponent<Rigidbody>();
      sphere.GetComponent<Rigidbody>().useGravity = false;
      Destroy(sphere.GetComponent<SphereCollider>());
      sphere.GetComponent<MeshFilter>().mesh = Popcorn.GetComponent<MeshFilter>().mesh;
      sphere.AddComponent<SphereCollider>();
    }
  }
	void Start () 
    {
        Reset();
	}
}
