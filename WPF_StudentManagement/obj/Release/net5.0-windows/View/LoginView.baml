   M S B A M L   `   `   `  ���� H  DWPF-LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_LoginForm.ViewWPF_LoginForm.View  A%clr-namespace:WPF_LoginForm.ViewModelWPF_LoginForm.ViewModel  K*clr-namespace:WPF_LoginForm.CustomControlsWPF_LoginForm.CustomControls  "    WPF_LoginForm.View.LoginView   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:WPF_LoginForm.View     ;	viewModel%clr-namespace:WPF_LoginForm.ViewModel     Ecustomcontrols*clr-namespace:WPF_LoginForm.CustomControls     -     � Title$  	LoginView��$	��550��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency$
 True�� � DataContext ,   &WPF_LoginForm.ViewModel.LoginViewModel   � 	Resources    BooleanToVisibility��%   &	        �� y���  �� Path$ IsViewVisible� �� Mode$ TwoWay=�	 �� 	Converter#	 [  .���� 
 �� CornerRadius$
 12������  �� ImageSource$ /Image/background.jpg�� j� Stretch$
 Fill=�._��� $
 10��$��1q� J� Opacity$
 0.45Q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ #8A2387�� � Offset$ 0Q�� $ #E94057��$
 0.75Q�� $ #F27121��$ 1Q����� $	 1,0&�$	 0,1&�.��� $ #89216B��$ 0Q�� $ #DA4453��$
 0.75Q�._��  � RowDefinitions �� $��30 ��� .+�� $��0�� � ColumnDefinitions �� �� $��25 ��� $��25 ��� $��5 �.+��� $��LOG IN��
�������$��10(�$��
Montserrat)�$��0��$��Center=�$��10,0,0,0q��� -    ��Name$ btnMinimize��$��0q�$��-��
�������$��16(�$��
Montserrat)� � Cursor$
 Hand��$��1������  �� 
TargetType" ��.���  �� Property � �� �� Value �#28AEED �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#278BEF����  �� 
TargetType" ��.R��� $��18��$��18��$
 9��#��z��._��� $��Center=�$��Center=��� -   $ btnClose��$��0q�$��X��
�������$��12(�$��
Montserrat)�$
 Hand��$��2������ " ��.���  � �� �#DA34AE P�  �@J�IsMouseOver$
 True��. ���  � �� �#C62DAE���� " ��.R��� $��18��$��18��$
 9��#��z��._��� $��Center=�$��Center=��� $	��220��$��1�� �� Orientation$ Vertical=�$��0,35,0,0q�.+��� $ ��/images/LOGO QT CENTER.png��$	��100��$��80���� $J��DLearning to code is useful no matter what your career ambitions are.��
�������$��12(�$��Medium"�$��
Montserrat)�$
��Wrap=� �� TextAlignment$ Center=��� $��Username�����#fff$��12(�$��Medium"�$��
Montserrat)�$��0,35,0,0q��� -    ��Name$ txtUser��$��13(�$��Medium"�$��
Montserrat)�
������ 
�������  �� 
CaretBrush
  �����
�������$��0,0,0,2q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q����� *
Username+! �� UpdateSourceTrigger$! PropertyChanged=�.��.���� $��Password�����#fff$��12(�$��Medium"�$��
Montserrat)�$��0,15,0,0q�3   -WPF_LoginForm.CustomControls.BindablePassword  $��28��$��0,5,0,0q�"   Password" �� *
Password+$ TwoWay=�$! PropertyChanged=��� 
�������$��12(�$��Medium"�$��
Montserrat)�$��0,10,0,0q�$
��Wrap=����� *ErrorMessage+�� -   $ btnLogin��$��0q�$��LOG IN��
�������$��12(�$��
Montserrat)�$
 Hand��$��0,30,0,0q����� *LoginCommand+���� " ��.���  � �� �#ad5389 P�  �@J�IsMouseOver$
 True��. ���  � �� �#3c1053���� " ��.R��� $	��150��$��40��$
 20��#��z��._��� $��Center=�$��Center=��� $ 
Horizontal=�$��Center=�$��0,15,0,0q�.+��� $��Forgot Password?��
�������$��12(�$��Medium"�$��
Montserrat)��� $��Reset��
�������$��12(�$��Medium"�$��
Montserrat)�$
 Hand��$��8,0,0,0q�