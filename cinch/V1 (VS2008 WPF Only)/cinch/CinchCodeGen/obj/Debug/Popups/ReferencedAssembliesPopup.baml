   M S B A M L   `   `   `  ����O  Kmscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      G CCinchCodeGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CinchCodeGenCinchCodeGen 5      M ISystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0895'clr-namespace:System.IO;assembly=System	System.IO 5      ,   &CinchCodeGen.ReferencedAssembliesPopup   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    5      4sys&clr-namespace:System;assembly=mscorlib    5      *localclr-namespace:CinchCodeGen    5      7sysIO'clr-namespace:System.IO;assembly=System    5      -   5          �Name$	  win��5       � Title$ Cinch MVVM Code Generator��5	       � Topmost .   � WindowStartupLocation$ CenterOwner=�5       � WindowState$ Normal=�5      $	��400��5      $	��600��5      $	��400��5      $	��600��5       � WindowStyle$
 None=�5         WindowTemplateKey#��[  5       � 
ResizeMode$ CanResizeWithGrip=�5       � AllowsTransparency . ��5
      Z�  � 	Resources 5        fileInfoTemplate	 �� Path��%K   &	       �� 5   
   .R�5      �� ��6   �� $
	 Name�5      5      .��5!      �� 
 �� CornerRadius$
 10��6   ���	#ff656565$��0q�66   ._�5#   
   � 
������ $��2q�6(   .+�5%      �� $
 10,10,10,10��6   
�������
���   �$��5q�5&   %   ._�5(      � ���	#ff656565 � RowDefinitions 5*      �� 5+      $��50 �6(   �� 5,      $��* �6(   �� 5-      $
��Auto �6(   .+�51      � -   5        $��0��51      $��Stretch=�6(   $��50��6F   $��0,0,0,0q�6R   
���   �.+�54      �� $��../Images/header.png��6    $	��250��6>   $��25��6J   $��10,5,5,5q�6V   $
��Left=�55      $��Center=�63   56      � 59      $��1��6   $��Stretch=�6(   $��Stretch=�5:       � ColumnDefinitions 5;      �� 5<      $��* �6/   �� 5=      $
��Auto �6/    5@      �� 5A      $
��Auto �6,   �� 5B      $��* �6,   .+�5E      �� $��Arial)�6    $��13(�63   $��0��6A   $��0��6N   $��2��5F      $2��,Add / Remove Available Referenced Assemblies��5G      $��5q�6O   $��Center=�5H      
���   �$��Italic$�5I      $
��Bold"�6+   $
��Left=�5J      �� 5L      
���   �$��1��64   $��0��6A   $��1��6Q   $��
10,0,10,10q�5M      $��Stretch=�5N      $��Stretch=�6;   $
 5��6W   ._�5P      �� -   5         ��Name$	 lst��5P   &   
������ 
������ $��5q�5Q   M   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5R        PropertyItemStyle#���  5S       �� AlternationCount$ 2��5U      #��[ 5V      $��Stretch=�5W      $��Stretch=�68   ��5T      �� *ReferencedAssemblies+ 5X   "    �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%k  &	       �� 5[   &   " ��6F    5\   *   P� 5]   .    �@��AlternationIndex$ 0��6_   . �5^   2   ��  � ��
 �����6O   5_   /   P� 5`   .    �@��AlternationIndex$ 1��6_   . �5a   2   ��  � �� �	#ff8080806O   5b   /   P� 5c   .    �@J�IsMouseOver . . �5d   2   ��  � �� �	#FFEF68036O   5e   /   5g   '   5i   #   5j      5k      �� 5m      
���   �
���   �$��1q�6H   $
 5��5n      $��0��6*   $��1��67   $��1��6G   $��2��5o      $��10,35,10,10q�6*   ._�5p      ��  �� Orientation$ Vertical=�6)   .+�5r   "   �� 
 � Tag$ ../Images/Add.png��6)   $��30��5s      $��30��6(   $��Center=�65     imageButtons#��[ 5t      $��2,4,2,4q�6C    � ToolTip$! Add new referenced assembly��5u      ��5v      �� *AddNewAssemblyCommand+�� 5x   "   $ ../Images/error.ico��6)   $��25��5y      $��25��6(   $��Center=�65   #��[ 5z      $��2,4,2,4q�6C   $( "Delete current referenced assembly��5{      ��5|      �� *RemoveAssemblyCommand+5~      5      5�      �� 5�      $��2��6!   $��Stretch=�6.   $��Stretch=�5�      $ 
Horizontal=�6/   .+�5�      �� $ ../Images/ok.png��6!    �� 	IsDefault . $��30��5�      $��30��6$   $
��Left=�61   #��[ 5�      $��20,10,10,10q�6?   $5 /Ok : Accept the current available Assembly list��5�      $
��True��5�      ��5�      �� *CloseActivePopUpCommand+5�      �� 5�      $ ../Images/cancel.png��6!    �� IsCancel . $��30��5�      $��30��6$   $
��Left=�61   #��[ 5�      $��20,10,10,10q�6?   $C =Cancel : Dismiss edits to the current available Assembly list��5�      5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Right=�62   $��	0,10,20,0q�6N   $	��Top=�5�   !   $
��Auto��69   $
��Auto��6G   .+�5�      �� -   5         ��Name$ btnClose��5�      $��	Wingdings)�6+   $��û��6B    J� RenderTransformOrigin$ 0.5,0.5&�5�      $��35,0,0,0q�61     mainWinButtons#��[ 5�      $ Close��5�      z�5�      V� 5�      .~�5�      ��  �� ScaleX$	 0.7Q�6-    �� ScaleY$	 0.7Q�6:   �� 5�       �� AngleX$ 0Q�6,     �� AngleY$  0Q�67   �� 5�      ! �� Angle$! -13.184Q�6.   T� 5�      " T� X$" 0Q�61   # T� Y$# 0Q�67   5�      5�      5�      5�      5�      5�      