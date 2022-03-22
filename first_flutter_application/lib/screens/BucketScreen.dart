import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/components/BottomNavigationBar.dart';
import 'package:first_flutter_application/components/BucketItemCard.dart';
import 'package:first_flutter_application/functions/TextFunctions.dart';
import 'package:first_flutter_application/screens/CheckOutScreen.dart';
import 'package:first_flutter_application/screens/MenuScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';

class BucketScreen extends StatefulWidget {
  @override
  State<BucketScreen> createState() => _BucketScreen();
}

class _BucketScreen extends State<BucketScreen> {
  double total_bill = 0.0;
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    total_bill = ScopedModel.of<MainModal>(context).getTotalBill();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      bottomSheet: Padding(
        padding: EdgeInsets.all(10.0),
        child: total_bill > 0.0
            ? Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  Text(
                    "Total bill : ${total_bill}",
                    style: TextStyle(fontSize: 18),
                  ),
                  ElevatedButton(
                      onPressed: () {
                        Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => CheckOutScreen()));
                      },
                      child: Text("CheckOut"))
                ],
              )
            : Row(),
      ),
      appBar: AppBar(
        title: Text("Bucket Item "),
      ),
      body: Container(
          child: Padding(
        padding: EdgeInsets.all(20.0),
        child:
            ScopedModelDescendant<MainModal>(builder: (context, child, model) {
          if (model.itemCount == 0) {
            return Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                Padding(
                  padding: EdgeInsets.only(top: 30.0),
                  child: Icon(
                    Icons.shopping_basket,
                    size: 100,
                  ),
                ),
                Padding(
                    padding: EdgeInsets.only(top: 10.0),
                    child: Text(
                      'Hungry ? Add something to your bucket !!!',
                      textAlign: TextAlign.center,
                    )),
                Padding(
                  padding: EdgeInsets.only(top: 10.0),
                  child: outlineButton('Start your order', () {
                    //GlobalKey globalKey= new GlobalKey(debugLabel: 'btm_app_bar');
                    BottomNavigationBar navigationBar =
                        globalKey.currentWidget as BottomNavigationBar;
                    navigationBar.onTap!(1);
                  }),
                )
              ],
            );
          } else {
            return ListView(
              children: List.generate(model.items.length, (index) {
                return BucketItemCard(
                  bucketItem: model.items[index],
                );
              }),
            );
          }
        }),
      )),
    );
  }
}
