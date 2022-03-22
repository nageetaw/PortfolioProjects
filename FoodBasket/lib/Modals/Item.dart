// modal class for list item
class Item {
  Item(
      {required this.itemName,
      required this.itemPrice,
      required this.itemDetails,
      required this.itemAddOns,
      required this.hasDrink,
      required this.totalDrinks,
      required this.drinks,
      required this.imageName,
      required this.TotalItemAddOns,
      required this.totalDrinksInItem});
  late String itemName;
  late double itemPrice;
  late String itemDetails;
  late var itemAddOns;
  late bool hasDrink;
  late int totalDrinks;
  late var drinks;
  late String imageName;
  late int TotalItemAddOns;
  late int totalDrinksInItem;

  // Item.fromJson(Map<String, dynamic> json) {
  //   itemName = json['itemName'];
  //   itemPrice = json['itemPrice'];
  //   itemDetails = json['itemDetails'];
  //   hasDrink = json['hasDrink'];
  //   totalDrinks = json['totalDrinks'];
  //   itemAddOns = json['itemAddOns'];
  //   drinks = json['drinks'];
  //   imageName = json['imageName'];
  //   TotalItemAddOns = json['TotalItemAddOns'];
  //   hasDrink = json['hasDrink'];
  //   totalDrinksInItem = json['totalDrinksInItem'];
  // }

  factory Item.fromRTDB(Map<String, dynamic> data) {
    // print(
    //     "------------------------------------from  item RTDB------------------");
    // print(data);
    return Item(
        itemName: data["itemName"] ?? 'name',
        itemPrice: data["itemPrice"].toDouble() ?? 0.0,
        itemDetails: data["itemDetails"] ?? 'details',
        itemAddOns: data["itemAddOns"] ?? [],
        hasDrink: data["hasDrink"] ?? false,
        totalDrinks: data["totalDrinks"] ?? 5,
        drinks: data["drinks"] ?? [],
        imageName: data["imageName"] ?? "imagename",
        TotalItemAddOns: data["TotalItemAddOns"] ?? 0,
        totalDrinksInItem: data["totalDrinksInItem"] ?? 0);
  }
  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['itemName'] = this.itemName;
    data['itemPrice'] = this.itemPrice;
    data['itemDetails'] = this.itemDetails;
    data['hasDrink'] = this.hasDrink;
    data['totalDrinks'] = this.totalDrinks;
    data['itemAddOns'] = this.itemAddOns;
    data['drinks'] = this.drinks;
    data['imageName'] = this.imageName;
    data['TotalItemAddOns'] = this.TotalItemAddOns;
    data['hasDrink'] = this.hasDrink;
    data['totalDrinksInItem'] = this.totalDrinksInItem;
    return data;
  }
}
