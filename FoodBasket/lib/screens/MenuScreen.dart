// import 'dart:html';

// import 'dart:html';

import 'package:first_flutter_application/Modals/Menu.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/functions/getImagesUrl.dart';
import 'package:first_flutter_application/publishers/menuPublisher.dart';
import 'package:first_flutter_application/screens/MenuItemScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:firebase_database/firebase_database.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:scoped_model/scoped_model.dart';

// use future builder instead of stream builder to fetch data once
// use Stream builder to fetch real time data from firebase and the show a list here-- follow tutoril https://www.youtube.com/watch?v=sXBJZD0fBa4,
// when using stream builder don't need to cancel streams, it automatically does that
// with future builder and stream builder you don't need statefullWidget,  they update state it self
class MenuScreen extends StatelessWidget {
  DatabaseReference _databaseReference = FirebaseDatabase.instance.ref();
  // var menuItems = [
  //   {
  //     "name": "deals",
  //     "icon": Icons.details,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: true,
  //           TotalItemAddOns: 2,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [
  //             {"name": "mayo", "price": 50},
  //             {"name": "chilli sause", "price": 30}
  //           ], // array of abject with name and price
  //           hasDrink: true,
  //           totalDrinks: 4,
  //           drinks: [
  //             {"name": "cola", "price": 10},
  //             {"name": "pakocola", "price": 15},
  //             {"name": "cola", "price": 10},
  //             {"name": "pakocola", "price": 15}
  //           ]),
  //       Item(
  //           itemName: "Burger",
  //           itemPrice: 150,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: true,
  //           totalDrinks: 4,
  //           drinks: [
  //             {"name": "cola", "price": 10},
  //             {"name": "pakocola", "price": 15},
  //             {"name": "cola", "price": 10},
  //             {"name": "pakocola", "price": 15}
  //           ]),
  //       Item(
  //           itemName: "Zinger",
  //           itemPrice: 50,
  //           itemDetails: "One Zinger with drink",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: true,
  //           totalDrinks: 2,
  //           drinks: [
  //             {"name": "cola", "price": 10},
  //             {"name": "pakocola", "price": 15}
  //           ]),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //     ]
  //   },
  //   {
  //     "name": "Care",
  //     "icon": Icons.details,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: [])
  //     ]
  //   },
  //   {
  //     "name": "Signature Boxes",
  //     "icon": Icons.add_box,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: [])
  //     ]
  //   },
  //   {
  //     "name": "Sharing",
  //     "icon": Icons.share,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: [])
  //     ]
  //   },
  //   {
  //     "name": "Promotion",
  //     "icon": Icons.mic_external_off,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: [])
  //     ]
  //   },
  //   {
  //     "name": "Mid night deals",
  //     "icon": Icons.lock_clock,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: [])
  //     ]
  //   },
  //   {
  //     "name": "Snaks",
  //     "icon": Icons.child_friendly,
  //     "onTap": () {},
  //     "menuItemsList": <Item>[
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: []),
  //       Item(
  //           itemName: "fries",
  //           itemPrice: 50,
  //           itemDetails: "One plate fries",
  //           hasItemAddOns: false,
  //           TotalItemAddOns: 0,
  //           itemFlavours: <String>["hello"],
  //           itemAddOns: [], // array of abject with name and price
  //           hasDrink: false,
  //           totalDrinks: 0,
  //           drinks: [])
  //     ]
  //   },
  // ];

  var menuItems = [];
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('MENU'),
      ),
      body: StreamBuilder(
        stream: MenuPublisher().menuListStream(),
        builder: (context, snapshot) {
          print("in builder");
          final menuItemHolder = <InkWell>[];
          if (snapshot.hasData) {
            print("snap shot has data " + snapshot.data.toString());
            final menuList = snapshot.data as List<Menu>;

            menuItemHolder.addAll(menuList.map((Element) {
              print(Element);
              return InkWell(
                child: Container(
                  child: Card(
                      child: Padding(
                    padding: EdgeInsets.all(10.0),
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.spaceBetween,
                      children: [
                        Container(
                          width: 50,
                          height: 50,
                          child: Image.network(
                              ScopedModel.of<MainModal>(context)
                                  .getUrl(Element.imageName)),
                        ),
                        // FutureBuilder(
                        //   future: loadImagesFromFirebaseStorage()
                        //       .getURL(Element.imageName),
                        //   builder: (context, AsyncSnapshot<String> snapshot) {
                        //     if (snapshot.connectionState ==
                        //         ConnectionState.done) {
                        //       return Container(
                        //         width: 50,
                        //         height: 50,
                        //         child: Image.network(
                        //           snapshot.data!,
                        //         ),
                        //       );
                        //     }
                        //     if (snapshot.connectionState ==
                        //             ConnectionState.waiting ||
                        //         !snapshot.hasData) {
                        //       return CircularProgressIndicator();
                        //     }
                        //     return Container();
                        //   },
                        // ),
                        Text(
                          Element.name,
                          style: TextStyle(fontSize: 18),
                        ),
                        Icon(
                          Icons.arrow_right,
                          size: 28,
                        )
                      ],
                    ),
                  )),
                ),
                //  ListTile(
                //     title: Text(Element.name), leading: Icon(Icons.menu)),
                onTap: () {
                  Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => MenuItemScreen(
                              items: Element.items, title: Element.name)));
                },
              );
            }));
          } else {
            print("snap shot is empty");
          }
          return Container(
              child: ListView(
            children: menuItemHolder,
          ));
        },
      ),
    );
  }
}
