import 'dart:ffi';

import 'package:first_flutter_application/Modals/Item.dart';
import 'package:first_flutter_application/screens/MenuItemScreen.dart';
import 'package:flutter/material.dart';

class Menu {
  late String name;
  late String imageName;
  List<Item> items = [];
  Menu(
      {Key? key,
      required this.name,
      required this.items,
      required this.imageName});

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['name'] = this.name;
    data['imageName'] = this.imageName;
    data['items'] = List<dynamic>.from(this.items.map((x) => x.toJson()));

    return data;
  }

  factory Menu.fromRTDB(Map<String, dynamic> data) {
    print("---------------------inside menu RTDB-------------------");
    print("${data["items"]}");
    List<dynamic>? listOfItem = data['items'];

    return Menu(
        name: data["name"],
        imageName: data["imageName"],
        items: List<Item>.from(listOfItem!
            .map((value) => Item.fromRTDB(Map<String, dynamic>.from(value)))));
  }
}
