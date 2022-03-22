import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/ScopedModel/ImagesURLModal.dart';
import 'package:first_flutter_application/components/BottomNavigationBar.dart';
import 'package:first_flutter_application/components/SideDrawer.dart';
import 'package:first_flutter_application/functions/getImagesUrl.dart';
import 'package:first_flutter_application/screens/BucketScreen.dart';
import 'package:first_flutter_application/screens/LoadingScreen.dart';
import 'package:first_flutter_application/screens/MenuScreen.dart';
import 'package:first_flutter_application/screens/MoreScreen.dart';
import 'package:flutter/cupertino.dart';
import 'package:scoped_model/scoped_model.dart';
import 'package:flutter/material.dart';

class HomeScreen extends StatefulWidget {
  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  bool isLoading = true;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();

    if (ScopedModel.of<MainModal>(context).ImagesNamesWithURL.length > 0) {
      // when images are already loaded from the firebase store
      setState(() {
        isLoading = false;
      });
    } else {
      loadImagesFromFirebaseStorage().DowloadImagesURL(context).then((value) {
        print("All images are dowloaded");
        setState(() {
          isLoading = false;
        });
      });
    }
  }

  final Pages = [Home(), MenuScreen(), BucketScreen(), MoreScreen()];
  int index = 0;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      bottomNavigationBar: BottomBar(context, index, (indexValue) {
        setState(() {
          index = indexValue;
        });
      }),
      body: isLoading == true ? LoadingScreen() : Pages[index],
    );
  }
}

class Home extends StatefulWidget {
  @override
  State<Home> createState() => _Home();
}

class _Home extends State<Home> {
  late Customer _customer;
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    setState(() {
      _customer = ScopedModel.of<MainModal>(context).customer;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        child: Column(
          mainAxisSize: MainAxisSize.max,
          children: [
            Flexible(
              child: Container(),
              flex: 1,
            ),
            Flexible(
                child: Container(
                    height: double.infinity,
                    width: double.infinity,
                    child: InkWell(
                      child: FutureBuilder(
                        future: loadImagesFromFirebaseStorage()
                            .getURL("value-bucket.png"),
                        builder: (context, AsyncSnapshot<String> snapshot) {
                          if (snapshot.connectionState ==
                              ConnectionState.done) {
                            return Container(
                              child: Image.network(snapshot.data!,
                                  fit: BoxFit.cover),
                            );
                          }
                          if (snapshot.connectionState ==
                                  ConnectionState.waiting ||
                              !snapshot.hasData) {
                            return CircularProgressIndicator();
                          }
                          return Container();
                        },
                      ),
                      onTap: () {},
                    )),
                flex: 6),
            Flexible(
              child: Container(),
              flex: 1,
            ),
            Flexible(
              child: Row(
                mainAxisSize: MainAxisSize.max,
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  InkWell(
                    child: FutureBuilder(
                      future:
                          loadImagesFromFirebaseStorage().getURL("wow-box.png"),
                      builder: (context, AsyncSnapshot<String> snapshot) {
                        if (snapshot.connectionState == ConnectionState.done) {
                          return Container(
                            width: 150,
                            height: 150,
                            child: Image.network(
                              snapshot.data!,
                              fit: BoxFit.cover,
                            ),
                          );
                        }
                        if (snapshot.connectionState ==
                                ConnectionState.waiting ||
                            !snapshot.hasData) {
                          return CircularProgressIndicator();
                        }
                        return Container();
                      },
                    ),
                    onTap: () {},
                  ),
                  InkWell(
                    child: FutureBuilder(
                      future: loadImagesFromFirebaseStorage()
                          .getURL("crunch_burger.png"),
                      builder: (context, AsyncSnapshot<String> snapshot) {
                        if (snapshot.connectionState == ConnectionState.done) {
                          return Container(
                            width: 150,
                            height: 150,
                            child: Image.network(snapshot.data!,
                                fit: BoxFit.cover),
                          );
                        }
                        if (snapshot.connectionState ==
                                ConnectionState.waiting ||
                            !snapshot.hasData) {
                          return CircularProgressIndicator();
                        }
                        return Container();
                      },
                    ),
                    onTap: () {},
                  )
                ],
              ),
              flex: 4,
            ),
            Flexible(
              child: Container(),
              flex: 1,
            ),
          ],
        ),
      ),
      drawer: drawer(context, _customer),
      appBar: AppBar(
        title: Text("Home"),
      ),
    );
  }
}
