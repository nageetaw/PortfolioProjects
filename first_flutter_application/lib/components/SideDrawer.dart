// import 'dart:html';

import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:first_flutter_application/main.dart';
import 'package:first_flutter_application/screens/profileScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

Widget drawer(BuildContext context, Customer _customer) {
  return Drawer(
    // Add a ListView to the drawer. This ensures the user can scroll
    // through the options in the drawer if there isn't enough vertical
    // space to fit everything.
    child: ListView(
      // Important: Remove any padding from the ListView.
      padding: EdgeInsets.zero,
      children: [
        DrawerHeader(
          decoration: BoxDecoration(
            color: Colors.blue,
          ),
          child: Text(
            _customer.firstName,
            style: TextStyle(fontSize: 24),
          ),
        ),
        // ListTile(
        //   title: Text('Orders'),
        //   onTap: () {
        //     // Update the state of the app
        //     // ...
        //     // Then close the drawer
        //     Navigator.pop(context);
        //     Navigator.push(context,
        //         MaterialPageRoute(builder: (context) => OrderScreen()));
        //   },
        // ),
        ListTile(
          title: const Text('Profile'),
          onTap: () {
            // Update the state of the app
            // ...
            // Then close the drawer
            Navigator.pop(context);
            Navigator.push(context,
                MaterialPageRoute(builder: (context) => profileScreen()));
          },
        ),
        ListTile(
          title: const Text('Log out'),
          onTap: () async {
            // clear preferences
            SharedPreferences preferences =
                await SharedPreferences.getInstance();
            await preferences.clear();
            Navigator.pop(context);
            Navigator.push(
                context, MaterialPageRoute(builder: (context) => MyApp()));
          },
        ),
      ],
    ),
  );
}
