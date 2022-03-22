import 'package:first_flutter_application/Modals/Item.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/functions/TextFunctions.dart';
import 'package:first_flutter_application/functions/getImagesUrl.dart';
import 'package:first_flutter_application/screens/MenuItemDetailsScreen.dart';
import 'package:first_flutter_application/screens/MenuItemScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';

class ItemCard extends StatelessWidget {
  Item item;
  BuildContext context;
  ItemCard({Key? key, required this.item, required this.context})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: Padding(
        padding: EdgeInsets.all(5.0),
        child: Card(
          child: Padding(
            padding: EdgeInsets.all(15.0),
            child: Column(
              children: [
                Container(
                  width: double.infinity,
                  height: 200,
                  child: Image.network(
                    ScopedModel.of<MainModal>(context).getUrl(item.imageName),
                    fit: BoxFit.cover,
                  ),
                )
                // FutureBuilder(
                //   future:
                //       loadImagesFromFirebaseStorage().getURL(item.imageName),
                //   builder: (context, AsyncSnapshot<String> snapshot) {
                //     if (snapshot.connectionState == ConnectionState.done) {
                //       return Container(
                //         width: double.infinity,
                //         height: 200,
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
                // Image.asset('assest/login-screen.jpg'),
                ,
                Padding(
                  padding: EdgeInsets.only(top: 5.0),
                  child: Text(item.itemDetails),
                ),
                Padding(
                  padding: EdgeInsets.only(top: 5.0),
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceBetween,
                    children: [
                      Text(
                        item.itemName,
                        style: TextStyle(fontSize: 18),
                      ),
                      Text(
                        '${item.itemPrice}',
                        style: TextStyle(fontSize: 18),
                      )
                    ],
                  ),
                ),
                Row(
                  children: [
                    Expanded(
                        child: ElevatedButton(
                      child: Text("Order Now"),
                      onPressed: () {
                        Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) =>
                                    MenuItemDetailsScreen(item: item)));
                      },
                    ))
                  ],
                )
              ],
            ),
          ),
        ),
      ),
    );
  }
}
