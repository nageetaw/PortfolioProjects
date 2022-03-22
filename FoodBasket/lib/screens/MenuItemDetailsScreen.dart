// ignore_for_file: prefer_collection_literals

import 'package:first_flutter_application/Modals/BucketItem.dart';
import 'package:first_flutter_application/Modals/Item.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/functions/getImagesUrl.dart';
import 'package:first_flutter_application/screens/MenuItemScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';

class MenuItemDetailsScreen extends StatefulWidget {
  Item item;

  MenuItemDetailsScreen({Key? key, required this.item}) : super(key: key);
  @override
  State<MenuItemDetailsScreen> createState() => _MenuItemDetailsScreenState();
}

class _MenuItemDetailsScreenState extends State<MenuItemDetailsScreen> {
  bool _expanded = false;
  int currentItemInBucket = 1;
  double itemCurrentPrice = 0.0;
  double extracharges0fAddOns = 0.0;
  var selectedAddOns;
  Map<String, String> selectedDrinks = new Map<String, String>();
  late List<String> selectedDrinkValue;
  int currentlySelectedTotalDrinks = 0;

// -----------------------------------on Init state------------------------------------------------------
  @override
  void initState() {
    super.initState();
    selectedAddOns =
        List.filled(widget.item.TotalItemAddOns, false, growable: false);

    selectedDrinkValue =
        List.filled(widget.item.totalDrinksInItem, "", growable: false);

    for (int i = 0; i < widget.item.totalDrinksInItem; i++) {
      selectedDrinkValue[i] =
          Map<String, dynamic>.from((widget.item.drinks[0] as Map))
              .entries
              .first
              .key;
      selectedDrinks["Drink${i}"] = selectedDrinkValue[i];
    }
  }
//-----------------------------on Init state------------------------------------------------------

  void _addItemToBucket(BucketItem item) {
    ScopedModel.of<MainModal>(context).addItem(item);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          leading: IconButton(
              onPressed: () {
                Navigator.of(context).pop();
              },
              icon: Icon(Icons.arrow_back)),
        ),
        bottomSheet: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Row(
              children: [
                IconButton(
                  onPressed: () {
                    if (currentItemInBucket > 1) {
                      setState(() {
                        currentItemInBucket--;
                      });
                    }
                  },
                  icon: Icon(
                    Icons.remove,
                    color: Colors.blue,
                    size: 30,
                  ),
                  tooltip: "decrease",
                ),
                Padding(
                  padding: EdgeInsets.only(left: 10.0, right: 10.0),
                  child: Text('${currentItemInBucket}'),
                ),
                IconButton(
                  onPressed: () {
                    setState(() {
                      currentItemInBucket++;
                    });
                  },
                  icon: Icon(
                    Icons.add,
                    color: Colors.blue,
                    size: 30,
                  ),
                  tooltip: "add",
                ),
              ],
            ),
            Padding(
              padding: EdgeInsets.only(right: 10.0),
              child: ElevatedButton(
                  onPressed: () {
//--------------------------------------------------------------------------------------------------------

                    var selectedAddOnsByCustomer = [];
                    for (int i = 0; i < widget.item.TotalItemAddOns; i++) {
                      if (selectedAddOns[i] == true) {
                        selectedAddOnsByCustomer.add({
                          "name": Map<String, dynamic>.from(
                                  widget.item.itemAddOns[i])
                              .entries
                              .first
                              .key,
                          "price": Map<String, dynamic>.from(
                                  widget.item.itemAddOns[i])
                              .entries
                              .first
                              .value
                        });
                      }
                    }

                    BucketItem currentItem = BucketItem(
                        totalChargesOfBucketItem:
                            ((widget.item.itemPrice * currentItemInBucket) +
                                (extracharges0fAddOns)),
                        itemName: widget.item.itemName,
                        imageName: widget.item.imageName,
                        itemPrice: widget.item.itemPrice,
                        itemQuantity: currentItemInBucket,
                        hasDrink: widget.item.hasDrink,
                        totalDrinks: selectedDrinks
                            .length, // total drinks a costomer can select for thos item
                        drinkChoice: selectedDrinks,
                        totalAddOns: selectedAddOnsByCustomer.length,
                        AddOnsChoice:
                            selectedAddOnsByCustomer // total add ons customer has selected with this item
                        );
                    // print("-------------------------------------------------");
                    // print(currentItem.itemName);

                    _addItemToBucket(currentItem);
                    Navigator.pop(context);
//--------------------------------------------------------------------------------------------------------
                  },
                  child: Text("ADD To BUCKET")),
            )
          ],
        ),
        body: SingleChildScrollView(
          child: Column(
            children: [
              Container(
                width: double.infinity,
                height: 350,
                child: Image.network(
                  ScopedModel.of<MainModal>(context)
                      .getUrl(widget.item.imageName),
                  fit: BoxFit.cover,
                ),
              ),
              // FutureBuilder(
              //   future: loadImagesFromFirebaseStorage()
              //       .getURL(widget.item.imageName),
              //   builder: (context, AsyncSnapshot<String> snapshot) {
              //     if (snapshot.connectionState == ConnectionState.done) {
              //       return Container(
              //         width: double.infinity,
              //         height: 350,
              //         child: Image.network(
              //           snapshot.data!,
              //           fit: BoxFit.cover,
              //         ),
              //       );
              //     }
              //     if (snapshot.connectionState == ConnectionState.waiting ||
              //         !snapshot.hasData) {
              //       return CircularProgressIndicator();
              //     }
              //     return Container();
              //   },
              // ),
              Padding(
                padding: EdgeInsets.all(10.0),
                child: Column(
                  children: [
                    Padding(
                      padding: EdgeInsets.only(top: 10.0, bottom: 10.0),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text(widget.item.itemName),
                          Text(
                              '${((widget.item.itemPrice * currentItemInBucket) + (extracharges0fAddOns))}'),
                        ],
                      ),
                    ),
                    Padding(
                      padding: EdgeInsets.only(top: 10.0, bottom: 10.0),
                      child: Row(
                        children: [
                          Expanded(
                              child: Text(
                            widget.item.itemDetails,
                            textAlign: TextAlign.start,
                            maxLines: 3,
                            textDirection: TextDirection.ltr,
                          )),
                        ],
                      ),
                    ),
                    if (widget.item.hasDrink)
                      for (int i = 0; i < widget.item.totalDrinksInItem; i++)
                        ExpansionTile(
                          title: Text("Drink ${i + 1}"),
                          children: [
                            Column(
                              children: [
                                for (int j = 0;
                                    j < widget.item.totalDrinks;
                                    j++)
                                  RadioListTile(
                                    title: Text(Map<String, dynamic>.from(
                                            (widget.item.drinks[j] as Map))
                                        .entries
                                        .first
                                        .key
                                        .toString()),
                                    value: Map<String, dynamic>.from(
                                            (widget.item.drinks[j] as Map))
                                        .entries
                                        .first
                                        .key
                                        .toString(),
                                    groupValue: selectedDrinkValue[i],
                                    onChanged: (String? value) {
                                      setState(() {
                                        selectedDrinkValue[i] =
                                            value! as String;
                                        selectedDrinks["Drink${i}"] =
                                            value as String;
                                      });
                                    },
                                  ),

                                // CheckboxListTile(
                                //   title: Text(Map<String, dynamic>.from(
                                //           (widget.item.drinks[i] as Map))
                                //       .entries
                                //       .first
                                //       .key),
                                //   // subtitle:
                                //   //     Text('${widget.item.drinks[i]["price"]}'),
                                //   value: selectedDrinks[i],
                                //   onChanged: (val) {
                                //     setState(() {
                                //       selectedDrinks[i] = val;
                                //     });

                                //     //  print(val);
                                //   },
                                // )
                              ],
                            )
                          ],
                        ),
                    ExpansionTile(
                      title: Text("Add Ons"),
                      children: [
                        Column(
                          children: [
                            for (int i = 0;
                                i < widget.item.TotalItemAddOns;
                                i++)
                              CheckboxListTile(
                                title: Text(Map<String, dynamic>.from(
                                        (widget.item.itemAddOns[i] as Map))
                                    .entries
                                    .first
                                    .key),
                                subtitle: Text(Map<String, dynamic>.from(
                                        (widget.item.itemAddOns[i] as Map))
                                    .entries
                                    .first
                                    .value
                                    .toString()),
                                value: selectedAddOns[i],
                                onChanged: (val) {
                                  setState(() {
                                    print(val);
                                    print(selectedAddOns[i]);
                                    if (val == true) {
                                      extracharges0fAddOns +=
                                          Map<String, dynamic>.from((widget
                                                  .item.itemAddOns[i] as Map))
                                              .entries
                                              .first
                                              .value
                                              .toDouble();
                                    } else if (val == false &&
                                        extracharges0fAddOns > 0) {
                                      extracharges0fAddOns -=
                                          Map<String, dynamic>.from((widget
                                                  .item.itemAddOns[i] as Map))
                                              .entries
                                              .first
                                              .value
                                              .toDouble();
                                    }

                                    selectedAddOns[i] = val;
                                    print(selectedAddOns[i]);
                                  });
                                },
                              )
                          ],
                        )
                      ],
                    )
                  ],
                ),
              ),
            ],
          ),
        ));
  }
}
