import 'package:first_flutter_application/Modals/BucketItem.dart';
import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/components/Appbar.dart';
import 'package:first_flutter_application/components/BottomNavigationBar.dart';
import 'package:first_flutter_application/screens/HomeScreen.dart';
import 'package:first_flutter_application/screens/MapScreen.dart';
import 'package:first_flutter_application/screens/MoreScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';
import 'package:firebase_database/firebase_database.dart';
import 'package:firebase_core/firebase_core.dart';

class CheckOutScreen extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => _CheckOutScreen();
}

class _CheckOutScreen extends State<CheckOutScreen> {
  bool _showLocationAlert = false;
  double total_bill = 0.0;
  //late String locality, subLocaloty;
  late Customer _customer;
  late List<BucketItem> _bucketItems;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    print("in init state---");
    total_bill = ScopedModel.of<MainModal>(context).getTotalBill();
    // check if user location is provided or not
    // locality = ScopedModel.of<MainModal>(context).Locality;
    // subLocaloty = ScopedModel.of<MainModal>(context).SubLocality;
    // print("nigi " + locality);
    // if (locality == "") {
    //   setState(() {
    //     _showLocationAlert = true;
    //   });
    // }
    setState(() {
      _customer = ScopedModel.of<MainModal>(context).customer;
      _bucketItems = ScopedModel.of<MainModal>(context).items;
    });
  }

  @override
  Widget build(BuildContext context) {
    void hanldePlaceOrderClick() async {
      // database
      DatabaseReference _databaseReference = FirebaseDatabase.instance.ref();
      String _key = ScopedModel.of<MainModal>(context).customer_key;

      final String CUSTOMERS = "Customers";

      List itemsList = [];
      for (int i = 0; i < _bucketItems.length; i++) {
        itemsList.add(_bucketItems[i].toJson());
      }

      List ordersList = [];
      for (int i = 0; i < _customer.orders.length; i++) {
        ordersList.add(_customer.orders[i]);
      }

      ordersList.add(itemsList);

      final _customerOrderReference = _databaseReference
          .child(CUSTOMERS + '/' + _key)
          .update({"orders": ordersList}).then((value) {
        print("value updated");
        // remove items from bucket
        ScopedModel.of<MainModal>(context).reSetItemCount();
        ScopedModel.of<MainModal>(context).resetBuckeItems();
        showDialog(
            context: context,
            builder: (context) => confrimationDialog(context));
      });
    }

    return
        // _showLocationAlert
        //     ? AlertDialog(
        //         title: Text("Check location"),
        //         content: Text("Please allow to check location to proceed further"),
        //         actions: [
        //           FlatButton(
        //               onPressed: () {
        //                 Navigator.pop(context);
        //                 BottomNavigationBar navigationBar =
        //                     globalKey.currentWidget as BottomNavigationBar;
        //                 navigationBar.onTap!(3);
        //                 // Navigator.push(context,
        //                 //     MaterialPageRoute(builder: (context) => MoreScreen()));
        //               },
        //               child: Text("Confrim")),
        //           FlatButton(
        //             onPressed: () {
        //               Navigator.pop(context);
        //             },
        //             child: Text("cancel"),
        //           )
        //         ],
        //       )
        //     :
        Scaffold(
      appBar: AppBar(
        title: Text("Check out"),
        leading: IconButton(
            onPressed: () {
              Navigator.pop(context);
            },
            icon: Icon(Icons.arrow_back)),
      ),
      bottomSheet: Row(
        children: [
          Expanded(
              child: Padding(
            padding: EdgeInsets.all(10.0),
            child: ElevatedButton(
              onPressed: hanldePlaceOrderClick,
              child: Text("Place Order"),
            ),
          ))
        ],
      ),
      body: Container(
        child: Padding(
          padding: EdgeInsets.all(10.0),
          child: SingleChildScrollView(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              children: [
                SizedBox(
                  height: 15,
                ),
                Divider(
                  height: 10,
                ),
                SizedBox(
                  height: 15,
                ),
                Row(
                  children: [
                    SizedBox(width: 40),
                    Text("User Details", style: TextStyle(fontSize: 20)),
                  ],
                ),
                SizedBox(
                  height: 15,
                ),
                Divider(
                  height: 10,
                ),
                SizedBox(
                  height: 15,
                ),
                Row(
                  children: [
                    Icon(
                      Icons.perm_identity,
                      size: 28,
                    ),
                    SizedBox(width: 40),
                    Text('${_customer.firstName} ${_customer.lastName}',
                        style: TextStyle(fontSize: 16)),
                  ],
                ),
                SizedBox(
                  height: 10,
                ),
                Row(
                  children: [
                    Icon(
                      Icons.location_city,
                      size: 28,
                    ),
                    SizedBox(width: 40),
                    Text(_customer.country, style: TextStyle(fontSize: 16)),
                    SizedBox(
                      width: 10,
                      child: Text(":"),
                    ),
                    Text(_customer.city, style: TextStyle(fontSize: 16))
                  ],
                ),
                SizedBox(
                  height: 10,
                ),
                Row(
                  children: [
                    Icon(
                      Icons.payment,
                      size: 28,
                    ),
                    SizedBox(width: 40),
                    Text("Cash on delivery", style: TextStyle(fontSize: 16)),
                  ],
                ),
                SizedBox(
                  height: 15,
                ),
                Divider(
                  height: 10,
                ),
                SizedBox(
                  height: 15,
                ),
                Row(
                  children: [
                    SizedBox(width: 40),
                    Text("Order Details", style: TextStyle(fontSize: 20)),
                  ],
                ),
                SizedBox(
                  height: 15,
                ),
                Divider(
                  height: 10,
                ),
                SizedBox(
                  height: 15,
                ),
                Row(
                  children: [
                    Text("Total Items: ${_bucketItems.length}",
                        style: TextStyle(fontSize: 16)),
                  ],
                ),
                SizedBox(
                  height: 10,
                ),
                Row(
                  children: [
                    Text("Total bill: ${total_bill}",
                        style: TextStyle(fontSize: 16)),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

AlertDialog confrimationDialog(BuildContext context) {
  return AlertDialog(
    title: Text("Order Placed"),
    content: Text("Your Order is placed"),
    actions: [
      FlatButton(
          onPressed: () {
            Navigator.push(
                context, MaterialPageRoute(builder: (context) => HomeScreen()));
          },
          child: Text("Ok")),
    ],
  );
}

AlertDialog alertDialog(BuildContext context) {
  return AlertDialog(
    title: Text("Check location"),
    content: Text("Please allow to check location to proceed further"),
    actions: [
      FlatButton(
          onPressed: () {
            Navigator.push(
                context, MaterialPageRoute(builder: (context) => MoreScreen()));
          },
          child: Text("Confrim")),
      FlatButton(
        onPressed: () {
          Navigator.pop(context);
        },
        child: Text("cancel"),
      )
    ],
  );
}
