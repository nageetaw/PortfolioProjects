// import 'dart:html';

import 'package:flutter/material.dart';
import 'package:json_annotation/json_annotation.dart';

@JsonSerializable()
class Customer {
  late String email;
  late String password;
  late String firstName;
  late String lastName;
  late String address;
  late String zipCode;
  late String phoneNo;
  late String country;
  late String city;
  var orders = [];
  late String accountCreatedDate;
  Customer(
      {Key? key,
      required this.email,
      required this.password,
      required this.firstName,
      required this.lastName,
      required this.address,
      required this.zipCode,
      required this.phoneNo,
      required this.country,
      required this.city,
      required this.orders,
      required this.accountCreatedDate});

  Customer.fromJson(Map<String, dynamic> json) {
    email = json['email'];
    password = json['password'];
    firstName = json['firstName'];
    lastName = json['lastName'];
    address = json['address'];
    zipCode = json['zipCode'];
    phoneNo = json['phoneNo'];
    country = json['country'];
    city = json['city'];
    orders = json['orders'];
    accountCreatedDate = json['accountCreatedDate'];
  }

  factory Customer.fromRTDB(Map<String, dynamic> data) {
    print("inside customer RTDB ${data["email"]}");
    return Customer(
      email: data["email"] ?? 'hello',
      password: data["password"] ?? 'hello',
      firstName: data["firstName"] ?? 'hello',
      lastName: data["lastName"] ?? 'hello',
      address: data["address"] ?? 'hello',
      zipCode: data["zipCode"] ?? 'hello',
      phoneNo: data["phoneNo"] ?? 'hello',
      country: data["country"] ?? 'hello',
      city: data["city"] ?? 'hello',
      orders: data["orders"] ?? [],
      accountCreatedDate: data["accountCreatedDate"] ?? 'hello',
    );
  }
  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = new Map<String, dynamic>();
    data['email'] = this.email;
    data['password'] = this.password;
    data['firstName'] = this.firstName;
    data['lastName'] = this.lastName;
    data['address'] = this.address;
    data['zipCode'] = this.zipCode;
    data['phoneNo'] = this.phoneNo;
    data['country'] = this.country;
    data['city'] = this.city;
    data['orders'] = this.orders;
    data['accountCreatedDate'] = this.accountCreatedDate;
    return data;
  }
}
