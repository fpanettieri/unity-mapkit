using UnityEngine;
using System.Collections;

public class MapKitTest : MonoBehaviour
{
	public MapKit mapKit;

	public void Start()
	{
		mapKit.ShowUserLocation(true);
	}
}
