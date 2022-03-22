import 'package:first_flutter_application/Modals/BucketItem.dart';
import 'package:first_flutter_application/Modals/Customer.dart';
import 'package:scoped_model/scoped_model.dart';

class BucketItemsModal extends Model {
  List<BucketItem> _items = [];
  int _itemCount = 0;
  String _Locality = "";
  String _SubLocality = "";
  late Customer _customer;
  late String _customer_key = "";

  String get customer_key => _customer_key;

  List<BucketItem> get items => _items;

  int get itemCount => _itemCount;

  void reSetItemCount() {
    this._itemCount = 0;
  }

  void resetBuckeItems() {
    this._items = [];
  }

  String get Locality => _Locality;

  Customer get customer => _customer;

  String get SubLocality => _SubLocality;

  Map _imagesNamesWithURL = new Map<String, String>();

  Map get ImagesNamesWithURL => _imagesNamesWithURL;

  void setCustomer(Customer curr_customer) {
    this._customer = curr_customer;
  }

  void setArea(String local, String subLocal) {
    this._Locality = local;
    this._SubLocality = subLocal;
    print("local ${local} : sublocal : ${subLocal}");
  }

  void addURL(String name, String url) {
    _imagesNamesWithURL[name] = url;
  }

  void setCustomerKey(String value) {
    this._customer_key = value;
  }

  String getUrl(String key) {
    return _imagesNamesWithURL[key];
  }

  void addItem(BucketItem item) {
    _items.add(item);
    _itemCount++;
    notifyListeners();
  }

  void removeItem(BucketItem item) {
    _items.remove(item);
    _itemCount--;
    notifyListeners();
  }

  void updateItem(BucketItem item) {
    for (int i = 0; i < _items.length; i++) {
      if (_items[i].itemName == item.itemName) {
        _items[i] = item;
        notifyListeners();
        print("updated");
        break;
      }
    }
  }

  double getTotalBill() {
    double total_bill = 0.0;
    for (int i = 0; i < _items.length; i++) {
      total_bill += _items[i].totalChargesOfBucketItem.toDouble();
    }
    return total_bill;
  }
}

class MainModal extends BucketItemsModal {}
