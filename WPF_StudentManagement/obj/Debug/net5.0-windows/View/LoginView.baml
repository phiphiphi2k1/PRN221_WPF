   M S B A M L   `   `   `  ����P  LWPF_StudentManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPF_StudentManagement.ViewWPF_StudentManagement.View  5   	   S.clr-namespace:WPF_StudentManagement.ViewModels WPF_StudentManagement.ViewModels  5   	   [2clr-namespace:WPF_StudentManagement.CustomControls$WPF_StudentManagement.CustomControls  5   	   *    $WPF_StudentManagement.View.LoginView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WPF_StudentManagement.View     5   	   D	viewModel.clr-namespace:WPF_StudentManagement.ViewModels     5   	   Mcustomcontrols2clr-namespace:WPF_StudentManagement.CustomControls     5   	   -   5          � Title$  	LoginView��5
   	   $	��550��6   $	��300��6(    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      5   /WPF_StudentManagement.ViewModels.LoginViewModel  5   
    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6'   	 �� 	Converter#	 [  65   .��5      �� 
 �� CornerRadius$
 12��6   ._�5!   
   �� $
 10��6   $��3q�5"       J� Opacity$ 1Q�5#      ��5$      �� 5%       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5&      �   winBorderColor1 � Color# [ 6#    � Offset$ 0Q�6L   � 5'        winBorderColor2# [ 6#   $	 0.8Q�6L   � 5(        winBorderColor3# [ 6#   $ 1Q�6L   5)      ��5,      �� 5-      $	 1,1&�6&   $	 0,0&�67   .��5.      �   primaryBackColor1# [ 6#   $ 0Q�6N   6[   � 5/        primaryBackColor2# [ 6#   $ 1Q�6N   6[   50      ._�53      �  � RowDefinitions 54      �� 55      $��30 �6$   �� 56      .+�59      � $��0��6    � ColumnDefinitions 5;      �� 5<      �� 5=      $��25 �6+   �� 5>      $��25 �6+   �� 5?      $��5 �6+   .+�5B      �� $��Loggin Form��6     
 color4#��[ 5C       $��12(�5D       $��
Montserrat)�5E       $��Medium"�5F       $��0��5G       $��Center=�5H       $��10,0,0,0q�5I       �� 5K      -   5         ��Name$ btnMinimize��5K      $��0q�5L      $��-��5M      
�������$��16(�5O      $��
Montserrat)�5P       � Cursor$
 Hand��5Q      $��1��5R      ��5U      �� 5V       �� 
TargetType" ��6$   .�5W   "   ��  �� Property � �� �� Value# [ 6?    �� Triggers 5X   "   P� 5Y   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5Z   *   ��  � �� 
 color3# [ 6G   5[   '   5]      ��5a      �� 5b       �� 
TargetType" ��6.   .R�5c   "   �� $��18��6)   $��18��64   $
 9��5d   )   #��z��5e   )   ._�5f   &   �� $��Center=�67   $��Center=�5g   7   5h   #   5i      5l      �� 5n      -   5        $ btnClose��5n      $��0q�5o      $��x��5p      
�������$��12(�5r      $��
Montserrat)�5s      $
 Hand��5t      $��2��5u      ��5x      �� 5y      " ��6$   .�5z   "   ��  � ��# [ 6?    5{   "   P� 5|   &    �@J�IsMouseOver$
 True��6E   . �5}   *   ��  � ��# [ 6G   5~   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��18��6)   $��18��64   $
 9��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      �� 5�      $	��220��6   $��1��5�       �� Orientation$ Vertical=�5�      $��0,35,0,0q�5�      .+�5�      �� $��/Images/logo.png��6   $	��180��66   $	��100��6B   �� 5�      $7��1It’s not a bug; it’s an undocumented feature.��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       �� 5�      $��Username��6    ���#fff$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�       
 color1#��[ 5�       �� 
CaretBrush# [ 5�       	 color10#��[	 5�      $��0,0,0,2q�5�      $��25��5�      $��Center=�5�      $��0,5,0,0q�5�      $��30,0,0,0q�5�      ��5�      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�.��5�   1   ��5�      �� 5�       �� ImageSource$ /Images/us.png��6)     j� Stretch$  Uniform=�5�   )   ! j� 
AlignmentX$
! Left=�5�   )   .��5�   .   5�      �� 5�      $��Password��6    ���#fff$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,15,0,0q�5�       ;   5WPF_StudentManagement.CustomControls.BindablePassword  5�      $��25��5�      $��0,5,0,0q�5�      "   Password" 5�      �� *
Password+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      #��[ 5�       $��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,10,0,0q�5�       $
��Wrap=�5�       ��5�       �� *ErrorMessage+5�       �� 5�      -   5        $ btnLogin��5�      $��0q�5�      $��Login��5�      
�������$��12(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��0,30,0,0q�5�      ��5�      �� *LoginCommand+��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#ad53896?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � �� �#3c10536G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��65   $
 10��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      �� 5�      $ 
Horizontal=�6!   $��Center=�5�   !   $��0,15,0,0q�5�   !   .+�5�      �� $��Forgot Password?��6$   
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       �� 5�      $��Reset��6$   
�������$��12(�5       $��Medium"�5      $��
Montserrat)�5      $
 Hand��5      $��8,0,0,0q�5      5     5     5     5     5	     5
     