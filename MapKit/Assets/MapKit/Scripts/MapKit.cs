using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class MapKit : MonoBehaviour
{
	public void Start()
	{
		#if !UNITY_EDITOR
		_MapKitPluginSetup();
		#endif
	}

	public void ShowUserLocation(bool visibility)
	{
		#if !UNITY_EDITOR
		_MapKitPluginShowUserLocation(visibility);
		#endif
	}

	#if UNITY_IPHONE
	[DllImport ("__Internal")] static extern private void _MapKitPluginSetup();
	[DllImport ("__Internal")] static extern private void _MapKitPluginShowUserLocation(bool visibility);
	#endif
}
