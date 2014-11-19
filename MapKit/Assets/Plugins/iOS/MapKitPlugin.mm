#import <Foundation/Foundation.h>
#import <MapKit/MapKit.h>

// Root view controller of Unity screen
extern UIViewController *UnityGetGLViewController();

// MapView reference
static MKMapView *mapView;

extern "C" {
	
	void _MapKitPluginSetup() {
		UIViewController *rootViewController = UnityGetGLViewController();
		mapView = [[MKMapView alloc] initWithFrame:rootViewController.view.frame];
		[rootViewController.view addSubview:mapView];
	}
	
	void _MapKitPluginShowUserLocation(bool visibility) {
		mapView.showsUserLocation = visibility;
	}
	
}
