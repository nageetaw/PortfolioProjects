import 'package:flutter/cupertino.dart';

class BucketItem {
  late String itemName;
  late double itemPrice;
  late int itemQuantity;
  late bool hasDrink;
  late int totalDrinks;
  String imageName;
  double totalChargesOfBucketItem = 0.0;
  Map<String, String> drinkChoice;

  late int totalAddOns;
  late var AddOnsChoice =
      []; // array of key value pair for addon and tier respective prices

  BucketItem(
      {Key? key,
      required this.itemName,
      required this.imageName,
      required this.itemPrice,
      required this.itemQuantity,
      required this.hasDrink,
      required this.totalDrinks,
      required this.drinkChoice,
      required this.totalAddOns,
      required this.AddOnsChoice,
      required this.totalChargesOfBucketItem}) {}

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['itemName'] = this.itemName;
    data['imageName'] = this.imageName;
    data['itemPrice'] = this.itemPrice;
    data['itemQuantity'] = this.itemQuantity;
    data['hasDrink'] = this.hasDrink;
    data['totalDrinks'] = this.totalDrinks;
    data['drinkChoice'] = this.drinkChoice;
    data['totalAddOns'] = this.totalAddOns;
    data['AddOnsChoice'] = this.AddOnsChoice;
    data['totalChargesOfBucketItem'] = this.totalChargesOfBucketItem;

    return data;
  }
}
