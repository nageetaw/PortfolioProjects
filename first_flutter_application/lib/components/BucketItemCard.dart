import 'package:first_flutter_application/Modals/BucketItem.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/components/BottomNavigationBar.dart';
import 'package:flutter/material.dart';
import 'package:scoped_model/scoped_model.dart';

class BucketItemCard extends StatefulWidget {
  BucketItem bucketItem;

  BucketItemCard({Key? key, required this.bucketItem}) : super(key: key);
  @override
  State<BucketItemCard> createState() => _BucketItemCard();
}

class _BucketItemCard extends State<BucketItemCard> {
  bool _isUpdateButtonDIsabled = true;
  late BucketItem bucketItem;
  late int currentItemInBucket;
  double additionalPriceAfterUpdate = 0.0;
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    bucketItem = widget.bucketItem;
    currentItemInBucket = widget.bucketItem.itemQuantity;
  }

  @override
  Widget build(BuildContext context) {
    return Container(
        child: InkWell(
      child: Card(
          child: Padding(
        padding: EdgeInsets.only(top: 5.0, bottom: 5.0, right: 20.0),
        child:
            Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
          Image.network(
            ScopedModel.of<MainModal>(context).getUrl(bucketItem.imageName),
            height: 80,
            width: 100,
          ),
          Text(bucketItem.itemName),
          Text('${bucketItem.totalChargesOfBucketItem}')
        ]),
      )),
      onTap: () async {
        // _displayDialog(context, bucketItem);
        await showGeneralDialog(
          context: context,
          barrierDismissible: false,
          transitionDuration: Duration(milliseconds: 500),
          transitionBuilder: (context, animation, secondaryAnimation, child) {
            return FadeTransition(
              opacity: animation,
              child: ScaleTransition(
                scale: animation,
                child: child,
              ),
            );
          },
          pageBuilder: (context, animation, secondaryAnimation) {
            return StatefulBuilder(builder: (context, setState) {
              return Scaffold(
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
                                if (currentItemInBucket ==
                                    bucketItem.itemQuantity)
                                  _isUpdateButtonDIsabled = true;
                                else
                                  _isUpdateButtonDIsabled = false;
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
                              if (currentItemInBucket ==
                                  bucketItem.itemQuantity)
                                _isUpdateButtonDIsabled = true;
                              else
                                _isUpdateButtonDIsabled = false;
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
                          onPressed: _isUpdateButtonDIsabled
                              ? null
                              : () {
                                  //----------------------------update item
                                  BucketItem updatedBucketItem = BucketItem(
                                      itemName: bucketItem.itemName,
                                      imageName: bucketItem.imageName,
                                      itemPrice: bucketItem.itemPrice,
                                      itemQuantity: currentItemInBucket,
                                      hasDrink: bucketItem.hasDrink,
                                      totalDrinks: bucketItem.totalDrinks,
                                      drinkChoice: bucketItem.drinkChoice,
                                      totalAddOns: bucketItem.totalAddOns,
                                      AddOnsChoice: bucketItem.AddOnsChoice,
                                      totalChargesOfBucketItem: bucketItem
                                              .totalChargesOfBucketItem +
                                          ((currentItemInBucket -
                                                      bucketItem.itemQuantity) *
                                                  bucketItem.itemPrice)
                                              .toDouble());

                                  ScopedModel.of<MainModal>(context)
                                      .updateItem(updatedBucketItem);
                                  Navigator.pop(context);
                                  BottomNavigationBar navigationBar = globalKey
                                      .currentWidget as BottomNavigationBar;
                                  navigationBar.onTap!(1);
                                },
                          child: Text("Update")),
                    )
                  ],
                ),
                appBar: AppBar(
                  leading: IconButton(
                      onPressed: () {
                        Navigator.of(context).pop();
                      },
                      icon: Icon(Icons.close)),
                ),
                body: Container(
                  width: MediaQuery.of(context).size.width,
                  height: MediaQuery.of(context).size.height,
                  padding: EdgeInsets.all(20),
                  color: Colors.white,
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.start,
                    crossAxisAlignment: CrossAxisAlignment.start,
                    mainAxisSize: MainAxisSize.min,
                    children: <Widget>[
                      Image.network(ScopedModel.of<MainModal>(context)
                          .getUrl(bucketItem.imageName)),
                      Padding(
                          padding: EdgeInsets.only(top: 10.0, bottom: 5.0),
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Text(
                                '${bucketItem.itemName} * ${currentItemInBucket}',
                                style: TextStyle(
                                    fontWeight: FontWeight.bold, fontSize: 22),
                              ),
                              Text(
                                '${(bucketItem.itemPrice * currentItemInBucket)} ',
                                style: TextStyle(
                                    fontWeight: FontWeight.bold, fontSize: 22),
                              )
                            ],
                          )),
                      if (bucketItem.hasDrink)
                        Row(
                          children: [
                            Padding(
                              padding: EdgeInsets.only(top: 15.0),
                              child: Text(
                                'Drinks',
                                style: TextStyle(
                                    fontWeight: FontWeight.bold, fontSize: 18),
                              ),
                            )
                          ],
                        ),
                      if (bucketItem.hasDrink)
                        Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              for (int i = 0; i < bucketItem.totalDrinks; i++)
                                Padding(
                                    padding:
                                        EdgeInsets.only(top: 5.0, bottom: 5.0),
                                    child: Expanded(
                                      child: Text(
                                        bucketItem.drinkChoice.entries
                                            .elementAt(i)
                                            .value,
                                        textAlign: TextAlign.start,
                                      ),
                                    )),
                            ]),
                      if (bucketItem.totalAddOns > 0)
                        Row(
                          children: [
                            Padding(
                              padding: EdgeInsets.only(top: 15.0),
                              child: Text(
                                'Includes',
                                style: TextStyle(
                                    fontWeight: FontWeight.bold, fontSize: 20),
                              ),
                            )
                          ],
                        ),
                      Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          mainAxisAlignment: MainAxisAlignment.start,
                          children: [
                            for (int i = 0; i < bucketItem.totalAddOns; i++)
                              Padding(
                                  padding:
                                      EdgeInsets.only(top: 5.0, bottom: 5.0),
                                  child: Expanded(
                                    child: Text(
                                      '${bucketItem.AddOnsChoice[i]["name"]}: ${bucketItem.AddOnsChoice[i]["price"]}',
                                      textAlign: TextAlign.start,
                                    ),
                                  )),
                          ]),
                      Align(
                          alignment: Alignment.bottomRight,
                          child: Padding(
                              padding: EdgeInsets.only(top: 10.0, bottom: 10.0),
                              child: Text(
                                  "Total : ${bucketItem.totalChargesOfBucketItem + ((currentItemInBucket - bucketItem.itemQuantity) * bucketItem.itemPrice)}",
                                  style: TextStyle(
                                      fontWeight: FontWeight.bold,
                                      fontSize: 18,
                                      color: Colors.blue)))),
                      Align(
                        alignment: Alignment.bottomRight,
                        child: IconButton(
                            onPressed: () {
                              BottomNavigationBar navigationBar = globalKey
                                  .currentWidget as BottomNavigationBar;
                              ScopedModel.of<MainModal>(context)
                                  .removeItem(bucketItem);
                              Navigator.of(context).pop();
                              if (ScopedModel.of<MainModal>(context)
                                      .itemCount ==
                                  0) navigationBar.onTap!(1);
                            },
                            icon: Icon(
                              Icons.delete,
                              color: Colors.red,
                            )),
                      )
                    ],
                  ),
                ),
              );
            });
          },
        );
      },
    ));
  }
}
