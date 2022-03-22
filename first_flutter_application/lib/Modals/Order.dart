import 'package:first_flutter_application/Modals/BucketItem.dart';

class Order {
  double amount = 0.0;
  int totalItem = 0;
  List<BucketItem> items;
  Order({required this.amount, required this.totalItem, required this.items});
  
}
