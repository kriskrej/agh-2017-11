using UnityEngine;

public class WaterLevelIncreaser : MonoBehaviour {
    [Range(0,100f)]public float velocity = 10;
	void Update () {
        transform.position = new Vector3(0, transform.position.y + Time.deltaTime * velocity/100f, 0);
	}
}
