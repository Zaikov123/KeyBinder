   M S B A M L   `   `   `  ����F  BKeyBinderV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KeyBinderV1.ViewKeyBinderV1.View  5   	   ?$clr-namespace:KeyBinderV1.ConvertersKeyBinderV1.Converters  5   	   &     KeyBinderV1.View.BindConstructor   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:KeyBinderV1.View     5   	   ;
converters$clr-namespace:KeyBinderV1.Converters     5   	     � Title$  BindConstructor��5	   	   $	��375��6!   $	��525��6.    � 	Resources 5
      B   <KeyBinderV1.Converters.ObservableCollectionToStringConverter )  %ObservableCollectionToStringConverter��%   &	          5   
   6;   5      .��5      � 
���iii� � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6    �� DisplayMemberPath$
 Name��6=   ��6   �� *Binds+5      �� 5   
   $��1��6   $��Stretch=�6"   .+�5      �� $
��Edit��6   �� 5      $��Delete��6   5      � 5   
   $��2��6   $��	130,0,0,0q�6#   $��2��66    5      �� 5       $��5* �6    �� 5!      $��1* �6    .+�5$      �� $��0��6   
�������" �� VerticalScrollBarVisibility$
 Auto=�6:    �� TextWrapping$
 Wrap=�6]    �� AcceptsReturn$
 True��6q   ��6�   �� *TextBoxLines+ �� 	Converter# [  	 �� Mode$	 OneWay=�.��6�   .��5%   )   5&      �� 5(      $��1��6   
 �� Orientation$
 
Horizontal=�6&   $��Stretch=�6?   .+�5*      �� $��0��6   $��AddDelay��6&   $��75��69   ��6D   �� *AddDelayCom+�� 5+      $��1��6   $��KeyDown��6&   $��75��68   ��6C   �� *
KeyDownCom+�� 5,      $��2��6   $��KeyUp��6&   $��75��66   ��6A   �� *
KeyUpCom+�� 5-      $��3��6   $	��Add��6&   $��75��64   
������6?   5.      5/      51      52      