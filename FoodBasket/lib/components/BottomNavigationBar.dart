import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/screens/HomeScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';

GlobalKey globalKey = new GlobalKey(debugLabel: 'bottom_app_bar');

Widget BottomBar(
    BuildContext context, int curr_index, Function(int indexValue) refresh) {
  const String HOME = 'Home', MENU = 'Menu', BUCKET = 'Bucket', MORE = 'More';

  return BottomNavigationBar(
    key: globalKey,
    currentIndex: curr_index,
    type: BottomNavigationBarType.fixed,
    backgroundColor: Color(0xFF6200EE),
    selectedItemColor: Colors.white,
    unselectedItemColor: Colors.white.withOpacity(.60),
    selectedFontSize: 14,
    unselectedFontSize: 14,
    onTap: (value) {
      // print(value);
      refresh(value);
    },
    items: [
      BottomNavigationBarItem(
        title: Text(HOME),
        icon: Icon(Icons.home),
      ),
      BottomNavigationBarItem(
        title: Text(MENU),
        icon: Icon(Icons.menu_open),
      ),
      BottomNavigationBarItem(
        title: Text(BUCKET),
        icon: Stack(children: <Widget>[
          new Icon(Icons.shopping_bag_sharp),
          ScopedModelDescendant<MainModal>(
            builder: (context, child, model) {
              if (model.itemCount > 0) {
                return new Positioned(
                    top: 0.0,
                    right: 0.0,
                    child: Container(
                      padding: EdgeInsets.symmetric(horizontal: 6, vertical: 2),
                      decoration: BoxDecoration(
                          shape: BoxShape.circle, color: Colors.red),
                      alignment: Alignment.center,
                      child: Text(
                        '${model.itemCount}',
                        style: TextStyle(color: Colors.white),
                      ),
                    ));
              }
              return Text("");
              // Text(
              //   '${model.itemCount}',
              //   style: Theme.of(context).textTheme.headline4,
              // );
            },
          ),
        ]),
        //   icon: Icon(Icons.shopping_basket)
      ),
      BottomNavigationBarItem(
        title: Text(MORE),
        icon: Icon(Icons.more_vert),
      ),
    ],
  );
}
