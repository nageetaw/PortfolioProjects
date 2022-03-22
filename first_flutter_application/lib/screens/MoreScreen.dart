import 'dart:async';
import 'dart:math';

import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/screens/AboutScreen.dart';
import 'package:first_flutter_application/screens/MapScreen.dart';
import 'package:first_flutter_application/screens/privacyAndPolicyScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:geolocator/geolocator.dart';
import 'package:geocoding/geocoding.dart';
import 'package:google_maps_flutter/google_maps_flutter.dart';
import 'package:scoped_model/scoped_model.dart';

class MoreScreen extends StatefulWidget {
  @override
  State<MoreScreen> createState() => _MoreScreen();
}

class _MoreScreen extends State<MoreScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text("Location"),
        ),
        body: Padding(
          padding: EdgeInsets.all(20.0),
          child: Column(children: [
            Row(
              children: [
                InkWell(
                  child: Row(children: [
                    IconButton(onPressed: () {}, icon: Icon(Icons.location_on)),
                    Text("View my Location"),
                  ]),
                  onTap: () async {
                    _determinePosition();
                    Position position = await Geolocator.getCurrentPosition(
                        desiredAccuracy: LocationAccuracy.high);

                    List<Placemark> placemarks = await placemarkFromCoordinates(
                        position.latitude, position.longitude);
                    print(placemarks.first);

                    ScopedModel.of<MainModal>(context).setArea(
                        placemarks.first.locality.toString(),
                        placemarks.first.subLocality.toString());

                    Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) =>
                                MapScreen(usersPositionCoordinates: position)));
                  },
                )
              ],
            ),
            Divider(
              height: 10,
              thickness: 1,
              indent: 20,
              endIndent: 0,
              color: Colors.grey,
            ),
            Row(
              children: [
                InkWell(
                  child: Row(children: [
                    IconButton(onPressed: () {}, icon: Icon(Icons.info)),
                    Text("About Us"),
                  ]),
                  onTap: () {
                    Navigator.push(context,
                        MaterialPageRoute(builder: (context) => AboutScreen()));
                  },
                )
              ],
            ),
            Divider(
              height: 10,
              thickness: 1,
              indent: 20,
              endIndent: 0,
              color: Colors.grey,
            ),
            Row(
              children: [
                InkWell(
                  child: Row(children: [
                    IconButton(onPressed: () {}, icon: Icon(Icons.policy)),
                    Text("Privacy and policy"),
                  ]),
                  onTap: () {
                    Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) => privacyAndPolicyScreen()));
                  },
                )
              ],
            ),
            Divider(
              height: 10,
              thickness: 1,
              indent: 20,
              endIndent: 0,
              color: Colors.grey,
            ),
          ]),
        ));
  }
}

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
