   M S B A M L   `   `   `  ����P  LWpf_GroceryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Wpf_GroceryManagementWpf_GroceryManagement  5   	   &     Wpf_GroceryManagement.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Wpf_GroceryManagement     5   	   -   5          � Title$  Grocery Management��5
   	   $	��550��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��224 �6   �� 5      $
��567* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��469 �6   .+�5   
   �� $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��	15,20,0,0q�5      $��16(�6'   
��� d �$
��Bold"�5      $��0��6&   $��21��63   $��Manage Grocery��6?   �� 5   
   -   5         ��Name$ Lbx_Grocery��5      $
��Left=�6'   $	��252��6B   $	��Top=�6O   $	��185��6g   $��	15,52,0,0q�5      $��1��6%   ��5      �� 5      .R�5      �� $	��0,4q�6    �� 5      �6   �� *
prodName+�� 5       �� 5!      �6   �� *	prod_id+5"      5#      5&      �� 5(   
   $
��Left=�6   $	��Top=�60   $	��239��6H   $	��300��6U   $��1��6a   $��1��5)      $��	19,59,0,0q�6"    � DataContext 65   ��  �� ElementName$ Lbx_Grocery�� �� Path$ SelectedItem�.+�5*      ��  �� Orientation$ 
Horizontal=�6   $	��0,5q�62   .+�5+      �� $��Product��6   $
��Wrap=�6+   $��66��6?   �� 5,      	 �� TextWrapping$
	 Wrap=�64   $	��212��6H   ��6   �� *
prodName+6H   5-      �� 5/      $ 
Horizontal=�6   $	��0,5q�62   .+�50      �� $��
Product ID��6   $
��Wrap=�6.   $��66��6B   �� 51      $
	 Wrap=�63   $	��212��6G   ��6   �� *	prod_id+6G   52      �� 54      $ 
Horizontal=�6   $	��0,5q�62   .+�55      �� $��Company��6   $
��Wrap=�6+   $��66��6?   �� 56      $�� ��6   $
	 Wrap=�6"   $	��212��66   57      �� 59      $ 
Horizontal=�6   $	��0,5q�62   .+�5:      �� $��
Unit Price��6   $
��Wrap=�6.   $��66��6B   �� 5;      $�� ��6   $
	 Wrap=�6"   $	��212��66   5<      �� 5>      $ 
Horizontal=�6   $	��0,5q�62   .+�5?      �� $��
Stock Left��6   $
��Wrap=�6.   $��66��6B   �� 5@      $�� ��6   $
	 Wrap=�6"   $	��212��66   5A      �� 5C      $ 
Horizontal=�6   $	��0,5q�62   .+�5D      �� $��Expiry Date��6   $
��Wrap=�6/   $��66��6C   (  "System.Windows.Controls.DatePicker  5E      6   5G      5I      �� 5K   
   $��
50,315,0,0q�6   $ 
Horizontal=�6)   $
��Left=�6B   $	��Top=�6]   $	��150��5L      $��45��6!   $��1��6-   .+�5M      �� -   5        
 ��Name$
 Btn_Add��5M      $	��Add��6<   $	��5,0q�6J   $��50��6W   $��31��6b   �� 5N      -   5        $
 Btn_Del��5N      $��Delete��6<   $	��5,0q�6M   $��50��6Z   $��31��6e   5O      �� 5Q   
   $��	15,10,0,0q�6   $ Vertical=�6(   $
��Left=�6?   $	��Top=�6Z   $	��180��6r   $��34��5R      $��1��6!   .+�5S      �� $
��Wrap=�6   $'��!Enter product name to be filtered��6,   $
��Left=�6U   $	��Top=�5T      $��9(�60   
�������$��14��6S   �� 5U      -   5         ��Name$ 
Tbx_filter��5U      $��18��6*   $
	 Wrap=�66   $	��144��6J    � ToolTip$  Enter part of product name��6V   5V      5W      5Y      5Z      