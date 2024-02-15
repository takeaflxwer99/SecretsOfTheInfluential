﻿using UnityEngine;
using System.Collections;

public class ST_PuzzleTile : MonoBehaviour 
{
	public Vector3 TargetPosition;

	public bool Active = true;

	public bool CorrectLocation = false;

	public Vector2 ArrayLocation = new Vector2();
	public Vector2 GridLocation = new Vector2();

	void Awake()
	{
		TargetPosition = this.transform.localPosition;

		StartCoroutine(UpdatePosition());
	}

	public  void LaunchPositionCoroutine(Vector3 newPosition)
	{
		TargetPosition = newPosition;

		StartCoroutine(UpdatePosition());
	}

	public IEnumerator UpdatePosition()
	{
		while(TargetPosition != this.transform.localPosition)
		{
			this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, TargetPosition, 10.0f * Time.deltaTime);
			yield return null;
		}

		if(ArrayLocation == GridLocation){CorrectLocation = true;}else{CorrectLocation = false;}

		if(Active == false)
		{
			this.GetComponent<Renderer>().enabled = false;
			this.GetComponent<Collider>().enabled = false;
		}

		yield return null;
	}

	public void ExecuteAdditionalMove()
	{
		LaunchPositionCoroutine(this.transform.parent.GetComponent<ST_PuzzleDisplay>().GetTargetLocation(this.GetComponent<ST_PuzzleTile>()));
	}

	void OnMouseDown()
	{
		LaunchPositionCoroutine(this.transform.parent.GetComponent<ST_PuzzleDisplay>().GetTargetLocation(this.GetComponent<ST_PuzzleTile>()));
	}
}
