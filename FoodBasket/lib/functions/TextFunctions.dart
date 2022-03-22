import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

Widget heading(value, style, left, top, right, bottom) {
  return Padding(
      padding: EdgeInsets.fromLTRB(left, top, right, bottom),
      child: Text(
        value,
        style: style,
        textAlign: TextAlign.left,
      ));
}

TextFormField textFormField(
    hint_Text, label_Text, icon, controller, validator) {
  return TextFormField(
    controller: controller,
    decoration: InputDecoration(
      icon: Icon(icon),
      hintText: hint_Text,
      labelText: label_Text,
    ),
  );
}

TextFormField textFormPasswordField(
    hint_Text, label_Text, icon, controller, validator) {
  return TextFormField(
    obscureText: true,
    enableSuggestions: false,
    autocorrect: false,
    controller: controller,
    decoration: InputDecoration(
      icon: Icon(icon),
      hintText: hint_Text,
      labelText: label_Text,
    ),
  );
}

OutlineButton outlineButton(value, onPressed) {
  return OutlineButton(
    onPressed: onPressed,
    child: Text(value),
  );
}
