//import 'dart:html';

import 'package:first_flutter_application/Modals/Item.dart';
import 'package:first_flutter_application/components/ItemCard.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class MenuItemScreen extends StatelessWidget {
  List<Item> items;
  String title;

  MenuItemScreen({Key? key, required this.items, required this.title})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(title),
      ),
      body: Container(
        child: ListView.builder(
            itemCount: items.length,
            itemBuilder: (BuildContext context, int index) {
              return ItemCard(
                item: items[index],
                context: context,
              );
            }),
      ),
    );
  }
}

