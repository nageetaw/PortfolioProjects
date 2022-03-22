// import 'dart:html';

import 'dart:collection';
import 'dart:convert';

import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/functions/Constants.dart';
import 'package:first_flutter_application/functions/TextFunctions.dart';
import 'package:first_flutter_application/screens/HomeScreen.dart';
import 'package:first_flutter_application/screens/LoginScreen.dart';
import 'package:first_flutter_application/screens/SignUpScreen.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';
import 'components/Appbar.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:firebase_database/firebase_database.dart';

Future<void> main() async {
  WidgetsFlutterBinding.ensureInitialized();

  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  final Future<FirebaseApp> _firebaseApp = Firebase.initializeApp();

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return ScopedModel(
      model: MainModal(),
      child: MaterialApp(
          title: 'Flutter Demo', // title of the app , it is header
          theme: ThemeData(
            primarySwatch: Colors.blue,
          ),
          home: FutureBuilder(
            future: _firebaseApp,
            builder: (context, snapShot) {
              if (snapShot.hasError) {
                //print("you have an error ${snapShot.error.toString()}");

                return Text("you app has some internal error");
              } else if (snapShot.hasData) {
                // future has been resolved and firebase has been initialized
                return FirstScreen();
              } else {
                return Center(
                  child: CircularProgressIndicator(),
                );
              }
            },
          )
          // body of the app
          ),
    );
  }
}

class FirstScreen extends StatefulWidget {
  @override
  State<FirstScreen> createState() => _FirstScreen();
}

class _FirstScreen extends State<FirstScreen> {
  String title = "First Screen";
  String login = "login";
  String signUp = "signUp";
  bool isAlreadyLogin = false;

  DatabaseReference _databaseReference = FirebaseDatabase.instance.ref();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    //print("in init state");
    // check shared preference if user data is avaibale or not
    _checkUserIsLoginOrNor();
  }

  _checkUserIsLoginOrNor() async {
    //print("checking");
    SharedPreferences pref = await SharedPreferences.getInstance();
    //print("checking 1");
    // //print(pref.getString(CUSTOMER_DETAILS));

    Map<String, dynamic> userMap =
        jsonDecode(pref.getString(CUSTOMER_DETAILS)!);

    // check if user already exists
    try {
      var customer = Customer.fromJson(userMap);

      // get the orders of current customers

      setState(() {
        isAlreadyLogin = true;
      });

      ScopedModel.of<MainModal>(context).setCustomer(customer);
      ScopedModel.of<MainModal>(context)
          .setCustomerKey(pref.getString(CUSTOMER_KEY)!);
      //print(isAlreadyLogin);
    } catch (e) {
      //print("error is getting user");
    }
  }

  @override
  Widget build(BuildContext context) {
    final ButtonStyle style =
        TextButton.styleFrom(primary: Theme.of(context).colorScheme.onPrimary);
    return isAlreadyLogin
        ? HomeScreen()
        : Scaffold(
            resizeToAvoidBottomInset: false,
            body: Center(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  Flexible(
                    child: Image.asset("assest/home-image.jfif"),
                    flex: 8,
                  ),
                  Flexible(
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          Row(children: [
                            Expanded(
                                child: Padding(
                              padding: EdgeInsets.all(20.0),
                              child: outlineButton(login, () {
                                Navigator.push(
                                  context,
                                  MaterialPageRoute(
                                      builder: (context) => LoginScreen()),
                                );
                              }),
                            ))
                          ]),
                          Row(children: [
                            Expanded(
                                child: Padding(
                                    padding: EdgeInsets.fromLTRB(
                                        20.0, 0.0, 20.0, 0.0),
                                    child: outlineButton(signUp, () {
                                      Navigator.push(
                                        context,
                                        MaterialPageRoute(
                                            builder: (context) =>
                                                SignUpScreen()),
                                      );
                                    })))
                          ])
                        ],
                      ),
                      flex: 2)
                ],
              ),
            ),
          );
  }
}
