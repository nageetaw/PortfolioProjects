import 'package:firebase_storage/firebase_storage.dart' as firebase_storage;
import 'package:first_flutter_application/ScopedModel/MainScopedModal.dart';
import 'package:first_flutter_application/ScopedModel/ImagesURLModal.dart';
import 'package:flutter/cupertino.dart';
import 'package:scoped_model/scoped_model.dart';

class loadImagesFromFirebaseStorage {
  Future<bool> DowloadImagesURL(BuildContext context) async {
    firebase_storage.ListResult result =
        await storage.ref('foodBasketImages').listAll();

    result.items.forEach((firebase_storage.Reference ref) {
      getURL(ref.name).then((value) {
        ScopedModel.of<MainModal>(context).addURL(ref.name, value);
      });
    });

    return true;
  }

  final firebase_storage.FirebaseStorage storage =
      firebase_storage.FirebaseStorage.instance;

  Future<String> getURL(String path) async {
    String downloadedURL =
        await storage.ref("foodBasketImages/$path").getDownloadURL();
    return downloadedURL;
  }
}
