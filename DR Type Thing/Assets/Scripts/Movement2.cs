using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement2 : MonoBehaviour {
	public int speed;
	private NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Awake () {
		navMeshAgent = GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hit, 1000)) {
				Debug.Log("raycast sent");
				navMeshAgent.destination = hit.point;
				navMeshAgent.Resume ();

			}

		}
		
	}
}
