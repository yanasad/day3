   M S B A M L   `   `   `  ����N  Jsadovnikovapractika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:sadovnikovapractikasadovnikovapractika  5   	   $    sadovnikovapractika.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:sadovnikovapractika     5   	   -   5          � Title$  Авторизация��5   	   $	��600��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�6O   .��5	      � -   5         �Name$ 	avtorizac��5	   "   ���	#FF5B7C92 � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$	 log��5      $��1��6    $��1��6-   $��3��6=   ���	#FFC4C8DC$	��370��6h   $��50��6t   �� 5   
   -   5        $ passw��5      $��3��6"   $��1��6/   $��3��6?   ���	#FFC4C8DC$	��370��6j   $��50��6v   $y�	Collapsed=�6�   G� 5   
   -   5         G�Name$ pwdPasswordBox��5      $��3��6/   $��1��6<   $��3��6L   ���	#FFC4C8DC$	��370��6w   $��50��6�   �� 5   
   -   5         ��Name$
 vxod��5   !   $��
Войти��6   $��5��6/   $��2��6<   ���	#FFC4C8DC$��50��6c   $��30(�6o   $��Expanded&�6}   ���	#FF5B7C926�   �� 5   
   -   5        $ 	registrac��5   D   $Q��KНе зарегистрированы? Зарегистрироваться��6   $��4��6W   $��1��6d   $��3��6t   $��40��6�   ���	#FF5B7C92���	#FF5B7C92$��23(�6�   6�   �� 5   
   -   5        $ openn��5      $��3��6    $��3��60   $��2��6=   $��50��6Q   $��50��6\   ���	#FF5B7C92��5       �� 5!       �� ImageSource$ /images/1442954.png��6   5#      �� 5$   
   -	   5        $
 save��5$      $��3��6   $��3��6/   $��2��6<   $��50��6P   $��50��6[   ���	#FF5B7C92��5%      �� 5&      $ /images/hide.png��6   5(      �� 5*   
   $��/images/3541930.png��6   $��1��6-   $��3��6=   $��50��6J   $
��Left=�6U   �� 5+   
   $+��%/images/free-icon-profile-7710521.png��6   $��1��6?   $��1��6O   $��50��6\   $
��Left=�6g   5,      5.      