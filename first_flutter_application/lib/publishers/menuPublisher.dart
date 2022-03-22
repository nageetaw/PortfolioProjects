import 'package:firebase_database/firebase_database.dart';
import 'package:firebase_core/firebase_core.dart';
import 'package:first_flutter_application/Modals/Menu.dart';

class MenuPublisher {
  // database
  DatabaseReference _databaseReference = FirebaseDatabase.instance.ref();

  Stream<List<Menu>> menuListStream() {
    final menuStream = _databaseReference.child("Menu").onValue;

    final streamToBePublish = menuStream.map((event) {
      //print(
      // "**********************************************************************");
      //print("total menu returened from database  ${event.snapshot.value}");

      final menuMap = Map<String, dynamic>.from(event.snapshot.value as Map);
      // print(
      //   "**********************************************************************");
      final MenuList = menuMap.entries.map((element) {
        final m =
            Menu.fromRTDB(Map<String, dynamic>.from(element.value as Map));
        //     print("++++++++++++++++++++++++++++++++++++++++++++++++++++");
        print(m.name);
        return m;
      }).toList();
      return MenuList;
    });
    return streamToBePublish;
  }
}
