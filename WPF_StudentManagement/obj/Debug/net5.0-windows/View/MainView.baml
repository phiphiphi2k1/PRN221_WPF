   M S B A M L   `   `   `  ����P  LWPF_StudentManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPF_StudentManagement.ViewWPF_StudentManagement.View  5   	   S.clr-namespace:WPF_StudentManagement.ViewModels WPF_StudentManagement.ViewModels  5   	   )    #WPF_StudentManagement.View.MainView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:WPF_StudentManagement.View     5   	   D	viewModel.clr-namespace:WPF_StudentManagement.ViewModels     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  MainView��5
   	   $	��700��6   $
��1300��6'    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      4   .WPF_StudentManagement.ViewModels.MainViewModel  5   
   .��5      � .+�5   
   ��  �� CornerRadius$ 10��6   $��1q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �    winBorderColor1 � Color# [  6#   	 � Offset$	 0Q�6L   � 5        winBorderColor2# [ 6#   $		 0.5Q�6L   � 5        winBorderColor3# [ 6#   $	 1Q�6L   5      ._�5       � 
 � ColumnDefinitions
 5!      �� 5"      $	��250 �6'   65   �� 5#      $��* �6'   63   .+�5&      �� $ 10, 0 , 0 ,10��6   $��0��5'      ��5(      �� 5)      $	 0,0&�6.   $ 11,0.7&�6?   .��5*      �   secondaryBackColor1# [ 6+   $	 0Q�6X   6e   � 5+        secondaryBackColor2# [ 6+   $	 1Q�6X   6e   5,      ._�5.      �� .+�5/      ��  �� Orientation$ 
Horizontal=�6%   $��35��6>   $��
15,25,0,40q�6J   .+�50      �� $��/Images/logo.png��6$   $��30��6>   �� 51      $��Code is like humor��6(     titleColor2#��[ 6B   $��20(�6l   $��Medium"�6z   $��Center=�6�   $��8q�6�   52      	� 54      -   5        $��btnDashBoard��54   J     
menuButton#��[ 6&    
 color1
 � Tag# [ 55       d� 	IsChecked$
 trueY�56   &   ��57   %   �� *DashBoardCommand+.��58      �� $ 
Horizontal=�6)   .+�59   "   !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6/     menuButtonIcon#��[ 6;   �� 5:   "   $��	DashBoard��6,    	 menuButtonText#��[	 6=   5;      5<      	� 5>      -   5        $��btnStudentMangement��5>   J   #��[ 6&    

 color2# [
 5?      ��5@   &   �� *StudentManagementCommand+.��5A      �� $ 
Horizontal=�6)   .+�5B   "     $
 User=�6/   #��[ 6;   �� 5C   "   $��User Management��6,   #��[	 6C   5D      5E      	� 5G      -   5        $��btnClass��5G   J   #��[ 6&    
 color3# [ 5H      ��5I   &   �� *ClassCommand+.��5J      �� $ 
Horizontal=�6)   .+�5K   "     $ 	BorderAll=�6/   #��[ 6@   �� 5L   "   $��Class��6,   #��[	 69   5M      5N      5O      5P      �� 5S      $ 0, 10 , 10 ,0��6   $��1��5T      ��5U      �� 5V      $	 1,1&�6.   $	 0,0&�6?   .��5W      �   primaryBackColor1# [ 6+   $	 0Q�6V   6c   � 5X        primaryBackColor2# [ 6+   $	 1Q�6V   6c   5Y      ._�5\      �  � RowDefinitions 5]      �� 5^      $��25 �6,   �� 5_      $��35 �6,   �� 5`      $��* �6,   .+�5b      �� -   5         ��Name$ pnlControlBar��5b   %   $��0��5c   !   $ 
Horizontal=�5d   !   $��RightToLeft=�5e   !   
������ $��0,0,5,0q�5g   !   .+�5l      �� -   5         ��Name$ btnClose��5l   %     controlButton#��[ 5m   !    
 color4# [ 5n   !   .��5p   "     $ Xmark=�6/     controlButtonIcon#��[ 6<   5q      �� 5r      -   5        $ btnMaximize��5r   %   #��[ 5s   !    
 color6# [ 5t   !   .��5v   "     $ Square=�6/   #��[ 6=   5w      �� 5x      -   5        $ btnMinimize��5x   %   #��[ 5y   !    
 color8# [ 5z   !   .��5|   "     $ WindowMinimize=�6/   $��12��6E   #��[ 6P   5}      5      � 5�      $��1��6   
 5�      �� 5�   "   $	��100 �63   �� 5�   "   $��* �63   .+�5�      �� $��1��6(   $��0 0 30 0q�5�   !   $��18(�5�   !   #��[ 5�   !   $��Center=�5�   !   $��Right=�5�   !   ��5�   !   �� *CurrentUserAccount.FullName+5�   !   5�      � 5�      $��2��6   .+�5�      �� ��5�   !   �� *CurrentView+5�      5�      5�      5�      5�      5�      5�      