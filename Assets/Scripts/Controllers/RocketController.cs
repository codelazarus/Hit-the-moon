using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

    private Rigidbody2D _rigidbody2D;
    public float force = 1000;
	// Use this for initialization
	void Start () {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.simulated = false;
	}
	

    public void Shoot()
    {
        _rigidbody2D.simulated = true;
        _rigidbody2D.AddForce(new Vector2(0, force));
    }

    public void MoonHit(GameObject moon)
    {
        Destroy(_rigidbody2D);
        transform.parent = moon.transform;
        SpawnerController.instance.SpawnRocket();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Moon"))
        {
            MoonHit(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("rocket"))
        {
            GameManager.instance.OnGameOver();
            //hasHit = true;
            //gameover
        }
    }
}
