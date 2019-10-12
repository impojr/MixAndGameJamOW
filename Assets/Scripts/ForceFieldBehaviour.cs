using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldBehaviour : MonoBehaviour
{
    public GameObject PlayerSword;
    public float timer, timer_max;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
		timer_max = 5f;
		StartCoroutine(ShieldTimer());
    }

    // Update is called once per frame
    void FixedUpdate()
    {

	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerSword)
        {

            print("Collision with Player Sword");

        }
    }

	public IEnumerator ShieldTimer()
	{
		while (true)
        {
			if (timer < timer_max) //&& spawnPoints.Count == maxEnemySpawns)
            {
				timer = timer + 0.5f;
                this.gameObject.GetComponent<Renderer>().enabled = true;
            }

	        else if (timer == 5f)
		    {
				timer = 0;
                this.gameObject.GetComponent<Renderer>().enabled = false;
                yield return new WaitForSeconds(10f);
                this.gameObject.GetComponent<Renderer>().enabled = true;
            }
			yield return new WaitForSeconds(1f);
			Debug.Log(timer);
		}
	}

	//private void ShieldTimer()
	//   {
	//	timer = +0.5f;

	//	if (timer > 1f && timer < 5f)
	//       {
	//           this.gameObject.SetActive(true);
	//       }
	//       else if (timer < 0 || timer > 5f)
	//       {
	//           this.gameObject.SetActive(false);
	//       }

	//   }

	//private void ResetShieldTimer()
	//{

	//    if (timer > 5f)
	//    {

	//        timer = 0;

	//    }

	//}

}
