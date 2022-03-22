import 'dart:async';
// import 'dart:html';
import 'dart:math';

import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:geolocator/geolocator.dart';
import 'package:geocoding/geocoding.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';

class MapScreen extends StatefulWidget {
  Position usersPositionCoordinates;
  MapScreen({Key? key, required this.usersPositionCoordinates})
      : super(key: key);
  @override
  State<MapScreen> createState() => _MapScreen();
}

class _MapScreen extends State<MapScreen> {
  late GoogleMapController mapController;

  final List<Marker> markers = [];

  void _onMapCreated(GoogleMapController controller) {
    setState(() {
      mapController = controller;
    });
  }

  // final CameraPosition _initalCameraPosition =
  //     CameraPosition(target: LatLng(27.7244, 68.8228));

  addMarker(coOrdinates) {
    int id = Random().nextInt(100);
    setState(() {
      markers.add(
          Marker(position: coOrdinates, markerId: MarkerId(id.toString())));
    });
  }

  @override
  void initState() {
    // TODO: implement initState
    super.initState();

    setState(() {
      markers.add(Marker(
          position: LatLng(widget.usersPositionCoordinates.latitude,
              widget.usersPositionCoordinates.longitude),
          markerId: MarkerId("djbjbd")));
    });
    
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Map'),
        ),
        body: GoogleMap(
            onMapCreated: _onMapCreated,
            markers: markers.toSet(),
            onTap: ((coordinates) {
              mapController.animateCamera(CameraUpdate.newLatLng(coordinates));
              addMarker(coordinates);
            }),
            mapType: MapType.normal,
            initialCameraPosition: CameraPosition(
                target: LatLng(widget.usersPositionCoordinates.latitude,
                    widget.usersPositionCoordinates.longitude),
                zoom: 17.0,
                bearing: 30,
                tilt: 80)),
      ),
    );
  }
}
// @override
// Widget build(BuildContext context) {
//   return Scaffold(
//     appBar: AppBar(
//       title: Text('More'),
//     ),
//     body: Container(
//       child: Padding(
//           padding: EdgeInsets.all(20.0),
//           child: Column(children: [
//             Row(
//               children: [
//                 Expanded(
//                     child: OutlineButton(
//                   onPressed: () async {
//                     _determinePosition();
//                     Position position = await Geolocator.getCurrentPosition(
//                         desiredAccuracy: LocationAccuracy.high);

//                     List<Placemark> placemarks =
//                         await placemarkFromCoordinates(
//                             position.latitude, position.longitude);
//                     print(placemarks.first);
//                   },
//                   child: Text("view my location"),
//                 ))
//               ],
//             ),
//           ])),
//     ),
//   );
// }

Future<Position> _determinePosition() async {
  bool serviceEnabled;
  LocationPermission permission;

  // Test if location services are enabled.
  serviceEnabled = await Geolocator.isLocationServiceEnabled();
  if (!serviceEnabled) {
    // Location services are not enabled don't continue
    // accessing the position and request users of the
    // App to enable the location services.
    return Future.error('Location services are disabled.');
  }

  permission = await Geolocator.checkPermission();
  if (permission == LocationPermission.denied) {
    permission = await Geolocator.requestPermission();
    if (permission == LocationPermission.denied) {
      // Permissions are denied, next time you could try
      // requesting permissions again (this is also where
      // Android's shouldShowRequestPermissionRationale
      // returned true. According to Android guidelines
      // your App should show an explanatory UI now.
      return Future.error('Location permissions are denied');
    }
  }

  if (permission == LocationPermission.deniedForever) {
    // Permissions are denied forever, handle appropriately.
    return Future.error(
        'Location permissions are permanently denied, we cannot request permissions.');
  }

  // When we reach here, permissions are granted and we can
  // continue accessing the position of the device.
  return await Geolocator.getCurrentPosition();
}



