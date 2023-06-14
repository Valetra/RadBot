import 'package:admin_panel/views/home_screen.dart';
import 'package:admin_panel/views/order_screen.dart';
import 'package:admin_panel/views/supply_screen.dart';

import 'package:flutter/material.dart';

void main() => runApp(const MyApp());

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      routes: {
        OrdersScreen.routeName: (context) => const OrdersScreen(),
        SuppliesScreen.routeName: (context) => const SuppliesScreen(),
      },
      title: 'Админ панель',
      home: const HomeScreen(),
    );
  }
}