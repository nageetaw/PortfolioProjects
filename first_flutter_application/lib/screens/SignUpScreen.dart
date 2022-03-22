import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:first_flutter_application/Modals/Item.dart';
import 'package:first_flutter_application/Modals/Menu.dart';
import 'package:first_flutter_application/components/Appbar.dart';
import 'package:first_flutter_application/functions/TextFunctions.dart';
import 'package:first_flutter_application/functions/snackbar.dart';
import 'package:first_flutter_application/main.dart';
import 'package:first_flutter_application/screens/HomeScreen.dart';
import 'package:first_flutter_application/screens/LoginScreen.dart';
import 'package:first_flutter_application/screens/MenuItemScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:firebase_database/firebase_database.dart';
import 'package:firebase_core/firebase_core.dart';

class SignUpScreen extends StatefulWidget {
  @override
  State<SignUpScreen> createState() => _SignUpScreenState();
}

class _SignUpScreenState extends State<SignUpScreen> {
  // variable
  String title = "SignUp";

  // databasae

  // lists
  List<String> cities = <String>['Sukkur', 'Ghotki', 'Karachi', 'Lahore'];
  List<String> countries = <String>['Pakistan', 'India', 'US', 'UK'];
  String dropdownValueCountry = 'Pakistan';
  String dropdownValueCity = 'Sukkur';
  static String snackbarMessage = "";
  late SnackBar snackBar;

  // controller
  TextEditingController emailController = new TextEditingController();
  TextEditingController passwordController = new TextEditingController();
  TextEditingController repeatPasswordController = new TextEditingController();
  TextEditingController firstNameController = new TextEditingController();
  TextEditingController lastNameController = new TextEditingController();
  TextEditingController addressController = new TextEditingController();
  TextEditingController zipCodeController = new TextEditingController();
  TextEditingController phoneNumberController = new TextEditingController();

  final _formKey = GlobalKey<FormState>();

  // TextStyles
  TextStyle headingStyle =
      new TextStyle(fontSize: 25, color: Colors.blueAccent);

  bool _matchPassword() {
    if (passwordController.text == repeatPasswordController.text) {
      return true;
    }
    return false;
  }

  bool _checkForValue() {
    if (emailController.text.length > 0 &&
        passwordController.text.length > 0 &&
        repeatPasswordController.text.length > 0 &&
        firstNameController.text.length > 0 &&
        lastNameController.text.length > 0 &&
        addressController.text.length > 0 &&
        zipCodeController.text.length > 0 &&
        phoneNumberController.text.length > 0) {
      return true;
    }
    return false;
  }

  // bool isDuplicateUser = false;
  // Future<bool> _checkForDuplicateUser() async {
  //   bool isDuplicateUser = false;
  //   await _cutomerReference
  //       .orderByChild("email")
  //       .equalTo(emailController.text)
  //       .once()
  //       .then((event) {
  //     print(event.snapshot.value);

  //     if (event.snapshot.value == null) {
  //       setState(() {
  //         isDuplicateUser = true;
  //       });
  //     }
  //   });
  //   print(isDuplicateUser);
  //   return isDuplicateUser;
  // }

  // Widget build
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        resizeToAvoidBottomInset: true,
        // appBar: Appbar(appBar: AppBar(), title: title),
        body: Padding(
            padding: EdgeInsets.all(20.0),
            child: SingleChildScrollView(
                physics: ClampingScrollPhysics(),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.stretch,
                  children: [
                    Image.asset('assest/login-screen.jpg'),
                    Form(
                      key: _formKey,
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.start,
                        children: <Widget>[
                          heading('User Account', headingStyle, 0.0, 20.0, 0.0,
                              5.0),
                          textFormField('Email', 'Email *', Icons.email,
                              emailController, () {}),
                          textFormPasswordField('Password', 'Password *',
                              Icons.lock, passwordController, () {}),
                          textFormPasswordField(
                              'Repeat Password',
                              'Repeat Password *',
                              Icons.lock,
                              repeatPasswordController,
                              () {}),
                          heading('Contact Information', headingStyle, 0.0,
                              30.0, 0.0, 5.0),
                          textFormField('First name', 'First name *',
                              Icons.person, firstNameController, () {}),
                          textFormField('Last name', 'Last name', Icons.person,
                              lastNameController, () {}),
                          textFormField('Address', 'Address *',
                              Icons.location_city, addressController, () {}),
                          textFormField(
                              'Post/Zip code',
                              'Post/Zip code',
                              Icons.local_post_office_rounded,
                              zipCodeController,
                              () {}),
                          textFormField('Phone number', 'Phone number *',
                              Icons.phone, phoneNumberController, () {}),
                          Row(
                            children: [
                              Expanded(
                                  child: DropdownButton<String>(
                                value: dropdownValueCountry,
                                icon: const Icon(Icons.arrow_downward),
                                elevation: 16,
                                style: const TextStyle(
                                    color: Colors.black45, fontSize: 16),
                                underline: Container(
                                  height: 1,
                                  color: Colors.black45,
                                ),
                                onChanged: (String? newValue) {
                                  setState(() {
                                    dropdownValueCountry = newValue!;
                                  });
                                },
                                items: countries.map<DropdownMenuItem<String>>(
                                    (String value) {
                                  return DropdownMenuItem<String>(
                                    value: value,
                                    child: Text(value),
                                  );
                                }).toList(),
                              ))
                            ],
                          ),
                          Row(
                            children: [
                              Expanded(
                                  child: DropdownButton<String>(
                                value: dropdownValueCity,
                                icon: const Icon(Icons.arrow_downward),
                                elevation: 16,
                                style: const TextStyle(
                                    color: Colors.black45, fontSize: 16),
                                underline: Container(
                                  height: 1,
                                  color: Colors.black45,
                                ),
                                onChanged: (String? newValue) {
                                  setState(() {
                                    dropdownValueCity = newValue!;
                                  });
                                },
                                items: cities.map<DropdownMenuItem<String>>(
                                    (String value) {
                                  return DropdownMenuItem<String>(
                                    value: value,
                                    child: Text(value),
                                  );
                                }).toList(),
                              ))
                            ],
                          ),
                          Row(
                            children: [
                              Expanded(
                                  child:
                                      outlineButton("Create Account", () async {
                                // check that all fields has value
                                if (_checkForValue()) {
                                  if (_matchPassword()) {
                                    // check for the duplicate user
                                    // _checkForDuplicateUser();
                                    // if (isDuplicateUser = true)
                                    // //  1- create a new customer
                                    // {
                                    print("in fi");
                                    Customer newCustomer = Customer(
                                        email: emailController.text,
                                        password: passwordController.text,
                                        firstName: firstNameController.text,
                                        lastName: lastNameController.text,
                                        address: addressController.text,
                                        zipCode: zipCodeController.text,
                                        phoneNo: phoneNumberController.text,
                                        country: dropdownValueCountry,
                                        city: dropdownValueCity,
                                        orders: [],
                                        accountCreatedDate:
                                            DateTime.now().toString());

                                    // 2- get the database reference
                                    DatabaseReference _databaseReference =
                                        FirebaseDatabase.instance.ref();
                                    final _cutomerReference = _databaseReference
                                        .child("Customers")
                                        .push();

                                    final _ordersReference = _databaseReference
                                        .child("Orders")
                                        .push();
                                    //3- push new customer
                                    // add user with unique id

                                    print(newCustomer.toJson());

                                    try {
                                      await _cutomerReference
                                          .set(newCustomer.toJson());

                                      await _ordersReference
                                          .set({"email": emailController.text});
                                      Navigator.push(
                                        context,
                                        MaterialPageRoute(
                                            builder: (context) =>
                                                LoginScreen()),
                                      );
                                    } catch (error) {
                                      setState(() {
                                        snackbarMessage =
                                            "Internal server error";
                                      });
                                      snackBar =
                                          getSnakBar(snackbarMessage, () {});
                                      ScaffoldMessenger.of(context)
                                          .showSnackBar(snackBar);
                                    }
                                    // } else {
                                    //   setState(() {
                                    //     snackbarMessage =
                                    //         "User already exist, Please login";
                                    //     print("in set state");
                                    //   });
                                    //   snackBar =
                                    //       getSnakBar(snackbarMessage, () {});
                                    //   ScaffoldMessenger.of(context)
                                    //       .showSnackBar(snackBar);
                                    // }
                                  } else {
                                    setState(() {
                                      snackbarMessage =
                                          "password does not match";
                                    });
                                    snackBar =
                                        getSnakBar(snackbarMessage, () {});
                                    ScaffoldMessenger.of(context)
                                        .showSnackBar(snackBar);
                                  }
                                } else {
                                  // Find the ScaffoldMessenger in the widget tree
                                  // and use it to show a SnackBar.
                                  setState(() {
                                    snackbarMessage = "Please fill all fields";
                                  });
                                  snackBar = getSnakBar(snackbarMessage, () {});
                                  ScaffoldMessenger.of(context)
                                      .showSnackBar(snackBar);
                                }
                              }))
                            ],
                          )
                        ],
                      ),
                    )
                  ],
                ))));
  }

  // getMenuItem() async {
  //   var tempAddOns = [
  //     {"1 Pc Chicken": 200},
  //     {"Coleslaw": 50},
  //     {"Hot Wings (10 Pcs)": 440},
  //     {"Cheese Slice": 40},
  //     {"Mayo Dip": 25},
  //     {"Vietnamese Dip Sauce": 25},
  //     {"French Fries Bucket (Mayo)": 290},
  //     {"French Fries Bucket (Vietnamese)": 290},
  //     {"Dinner Roll": 25},
  //   ];

  //   var tempDrinks = [
  //     {"Pepsi": 90},
  //     {"7UP": 90},
  //     {"Mirinda": 90},
  //     {"Mountain Dew": 90},
  //     {"Diet Pepsi": 90}
  //   ];
  //   Item item = Item(
  //     itemName: "Value Bucket",
  //     itemPrice: 1295,
  //     itemDetails: "9 Pcs Hot & Crispy Chicken",
  //     itemAddOns: tempAddOns,
  //     hasDrink: false,
  //     totalDrinks: 5,
  //     drinks: tempDrinks,
  //     imageName: 'value-bucket.png',
  //     totalDrinksInItem: 0,
  //     TotalItemAddOns: 9,
  //   );

  //   Item item2 = Item(
  //     itemName: "Family Festival 1",
  //     itemPrice: 1495,
  //     itemDetails:
  //         '4 Krunch Burgers + 4 Pcs Chicken + 2 Dinner Rolls + 1.5 Ltr Drink',
  //     itemAddOns: tempAddOns,
  //     hasDrink: true,
  //     totalDrinks: 5,
  //     drinks: tempDrinks,
  //     imageName: 'family-festival-1.png',
  //     totalDrinksInItem: 1,
  //     TotalItemAddOns: 9,
  //   );

  //   Item item3 = Item(
  //       itemName: "Family Festival 2",
  //       itemPrice: 1550,
  //       itemDetails:
  //           '2 Zingers + 2 Krunch Burgers + 4 Pcs Chicken + 2 Dinner Rolls + 1.5 Ltr Drink',
  //       itemAddOns: tempAddOns,
  //       hasDrink: true,
  //       totalDrinks: 5,
  //       drinks: tempDrinks,
  //       imageName: 'family-festival-2.png',
  //       TotalItemAddOns: 9,
  //       totalDrinksInItem: 1);

  //   Item item4 = Item(
  //       itemName: "Family Festival 3",
  //       itemPrice: 1950,
  //       itemDetails: '5 Pcs Hot & Crispy Chicken + 1 Large Fries + 2 Drinks.',
  //       itemAddOns: tempAddOns,
  //       hasDrink: true,
  //       totalDrinks: 5,
  //       drinks: tempDrinks,
  //       imageName: 'family-festival-3.png',
  //       totalDrinksInItem: 1,
  //       TotalItemAddOns: 9);

  //   Item item5 = Item(
  //       itemName: "Family Bucket",
  //       itemPrice: 1725,
  //       itemDetails:
  //           '9 Pcs Chicken + 2 Coleslaws + 1 Fries Bucket + 1.5L Drink',
  //       itemAddOns: tempAddOns,
  //       hasDrink: true,
  //       totalDrinks: 5,
  //       drinks: tempDrinks,
  //       imageName: 'family-bucket.png',
  //       totalDrinksInItem: 1,
  //       TotalItemAddOns: 9);
  //   // Item item6 = Item(
  //   //     itemName: "Bone and Boneless",
  //   //     itemPrice: 275,
  //   //     itemDetails: '1 piece of hot & crispy chicken with 2 zinger strips.',
  //   //     itemAddOns: tempAddOns,
  //   //     hasDrink: false,
  //   //     totalDrinks: 5,
  //   //     drinks: tempDrinks,
  //   //     imageName: 'bone-and-boneless.png',
  //   //     totalDrinksInItem: 0,
  //   //     TotalItemAddOns: 9);

  //   List<Item> items = [item, item2, item3, item4, item5];

  //   MenuModal menuItem = MenuModal(name: "Sharing", items: items);

  //   DatabaseReference _databaseReference = FirebaseDatabase.instance.ref();

  //   //3- push new customer
  //   final _cutomerReference =
  //       _databaseReference.child("Menu").push(); // add user with unique id

  //   print(menuItem.toJson());

  //   try {
  //     print("before");
  //     await _cutomerReference.set(menuItem.toJson());
  //     print("after");
  //   } catch (error) {
  //     print("Error in adding new menu " + error.toString());
  //   }
  // }

}
