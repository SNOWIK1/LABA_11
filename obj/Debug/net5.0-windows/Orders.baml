   M S B A M L   `   `   `  ����B  >LABA_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LABA_11LABA_11  5   	       LABA_11.Orders   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LABA_11     5   	     � Title$>  8Заказы CD/DVD дисков по каталогам��5   	   
�������$	��600��6J   $	��800��6W   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��0.3* �6   .+�5   
   �� -   5         ��Name$ games��5   +    �� MaxDropDownHeight$	 250��6   $��45��6:   $	��250��6I   $	��Top=�6X   $��0 10 0 0q�6p   �� 5   
   -   5        $ 	education��5   +   $	 250��6   $��1��6>   $��45��6N   $	��250��6]   $	��Top=�6l   $��0 10 0 0q�6�   �� 5   
   -   5         ��Name$ orders��5      $��2��6#   
�������63   �� 5   
   -   5        $(��"Добавить в корзину��5      $��20(�6.   $��SemiBold"�6<   $��1��6R   $��0��6_   $��40��6o   $	��210��6~   6�   �� 5   
   -   5        $(��"Удалить из корзины��5      $��20(�6.   $��SemiBold"�6<   $��1��6R   $��1��6_   $��40��6o   $	��210��6~   6�   �� 5   
   -   5         ��Name$ numberOfOrders��5      $��20(�6(   $��SemiBold"�66   $��1��6L   $��2��6Y   5      5      