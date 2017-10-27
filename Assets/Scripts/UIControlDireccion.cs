using UnityEngine;

public class UIControlDireccion : MonoBehaviour {

    Transform tanque;

    float X = 50;
    float Y = 100;
    float Z = 100;
    float W = -50;

    // Sincroniza la rotacion con el cubo
    public bool sigueAlCubo = false;

	// Use this for initialization
	void Start () {
        tanque = GameObject.Find("Tanque").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        tanque.transform.Rotate(Vector3.up);

        if (!sigueAlCubo)
        {
            transform.rotation = new Quaternion(X, Y, Z, W);
        }
	}
}
