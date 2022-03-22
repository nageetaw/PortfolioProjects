import 'dart:async';
import 'dart:collection';
import 'dart:convert';
import 'dart:math';

import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/components/Appbar.dart';
import 'package:first_flutter_application/functions/Constants.dart';
import 'package:first_flutter_application/functions/TextFunctions.dart';
import 'package:first_flutter_application/functions/snackbar.dart';
import 'package:first_flutter_application/screens/HomeScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:firebase_database/firebase_database.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:scoped_model/scoped_model.dart';

class LoginScreen extends StatefulWidget {
  @override
  State<LoginScreen> createState() => _LoginScreen();
}

class _LoginScreen extends State<LoginScreen> {
  String title = "Login";
  String messageForCredentials = "";
  static String snackbarMessage = "";
  late SnackBar snackBar;

  // controllers
  TextEditingController emailController = new TextEditingController();
  TextEditingController passwordController = new TextEditingController();

  // database
  DatabaseReference _databaseReference = FirebaseDatabase.instance.ref();
  late StreamSubscription _customerStream;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
  }

  void _activateLoginAuthListener() {
    final String CUSTOMERS = "Customers";
    final _customerReference = _databaseReference.child(CUSTOMERS);

    _customerReference
        .orderByChild("email")
        .equalTo(emailController.text)
        .once()
        .then((event) {
      print(event.snapshot.value);

      if (event.snapshot.value == null) {
        setState(() {
          snackbarMessage = "User not exists";
          print("in set state");
        });
        snackBar = getSnakBar(snackbarMessage, () {});
        ScaffoldMessenger.of(context).showSnackBar(snackBar);
      } else {
        final data = Map<String, dynamic>.from(event.snapshot.value as Map);

        data.forEach((key, value) {
          try {
            print('key : ${key}');
            final customer =
                Customer.fromRTDB(Map<String, dynamic>.from(value as Map));

            if (customer.password == passwordController.text) {
              // before pushing new route add data to shared preference

              _addCustomerDataToSharedPrefrences(customer, key);
              Navigator.push(context,
                  MaterialPageRoute(builder: (context) => HomeScreen()));
            } else {
              setState(() {
                messageForCredentials = "Incorrect password";
              });
            }
          } catch (e) {
            print("error ${e}");
          }
        });
      }
    });
  }

  _addCustomerDataToSharedPrefrences(Customer customer, String key) async {
    SharedPreferences pref = await SharedPreferences.getInstance();
    String json = jsonEncode(customer);
    pref.setString(CUSTOMER_DETAILS, json);
    pref.setString(CUSTOMER_KEY, key);
    ScopedModel.of<MainModal>(context).setCustomer(customer);
    ScopedModel.of<MainModal>(context).setCustomerKey(key);
    //print(json);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      resizeToAvoidBottomInset: true,
      // appBar: Appbar(appBar: AppBar(), title: title),
      body: Center(
          child: Padding(
        padding: EdgeInsets.all(20.0),
        child: Column(children: [
          Flexible(
            child: Image.asset(
              'assest/login-screen.jpg',
              width: double.infinity,
              height: 400,
            ),
            flex: 5,
          ),
          Flexible(
              child: SingleChildScrollView(
                child: Column(
                  // mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                  // crossAxisAlignment: CrossAxisAlignment.center,
                  mainAxisSize: MainAxisSize.min,
                  children: [
                    // email field

                    textFormField('Email', 'Email *', Icons.person,
                        emailController, () {}), // password field

                    textFormPasswordField('Password', 'Password *', Icons.lock,
                        passwordController, () {}),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Padding(
                          padding: EdgeInsets.only(top: 10.0),
                          child: Text('${messageForCredentials}',
                              textAlign: TextAlign.center,
                              style: TextStyle(
                                fontSize: 16,
                                color: Colors.red,
                                decoration: TextDecoration.none,
                              )),
                        )
                      ],
                    ),
                    Row(
                      children: [
                        Expanded(
                            child: Padding(
                                padding: EdgeInsets.all(20.0),
                                child: outlineButton("Login", () {
                                  if (emailController.text.length > 0 &&
                                      passwordController.text.length > 0) {
                                    _activateLoginAuthListener();
                                  } else {
                                    setState(() {
                                      snackbarMessage =
                                          "Please fill all fields";
                                    });
                                    snackBar =
                                        getSnakBar(snackbarMessage, () {});
                                    ScaffoldMessenger.of(context)
                                        .showSnackBar(snackBar);
                                  }
                                }))),
                      ],
                    ),

                    RichText(
                      textAlign: TextAlign.center,
                      text: TextSpan(
                        style: DefaultTextStyle.of(context).style,
                        children: const <TextSpan>[
                          TextSpan(
                              text: "forget password?  \n\n",
                              style: TextStyle(
                                fontSize: 12,
                                color: Colors.red,
                                decoration: TextDecoration.none,
                              )),
                          TextSpan(
                              text: "don't have an account?  \n",
                              style: TextStyle(
                                fontSize: 12,
                                color: Colors.black,
                                decoration: TextDecoration.none,
                              )),
                          TextSpan(
                            text: 'register now!',
                            style: TextStyle(
                                fontWeight: FontWeight.bold,
                                decoration: TextDecoration.none,
                                fontSize: 12,
                                color: Colors.blue),
                          ),
                        ],
                      ),
                    )
                  ],
                ),
              ),
              flex: 5),
        ]),
      )),
    );
  }

  @override
  void deactivate() {
    // _customerStream.cancel();
    super.deactivate();
  }
}
