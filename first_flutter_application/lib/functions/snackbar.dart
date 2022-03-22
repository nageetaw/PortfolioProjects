import 'package:flutter/material.dart';

SnackBar getSnakBar(snackbarMessage, onPressed) {
  return SnackBar(
    content: Text('${snackbarMessage}'),
    action: SnackBarAction(
        textColor: Colors.red, label: 'close', onPressed: onPressed),
  );
}
