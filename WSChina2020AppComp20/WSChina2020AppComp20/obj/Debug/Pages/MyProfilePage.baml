   M S B A M L   `   `   `  ����O  KWSChina2020AppComp20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WSChina2020AppComp20.PagesWSChina2020AppComp20.Pages  5      .    (WSChina2020AppComp20.Pages.MyProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:WSChina2020AppComp20.Pages     5        N� Title$  MyProfilePage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  
  MainTB#��[  6   $��2��64   
My Profile6T   �� 5   
    �� Orientation$ Vertical=�6   $��Center=�6,   $��0��6I   $��Center=�6Y   .+�5      ��   SecondaryTB#��[ 6   $
��Left=�6p   $��5q�6�   ��6=   ��  �� StringFormat$ 	Name: {0}�� �� Path$
 name�6�   �� 5      #��[ 6   $
��Left=�6t   $��5q�6�   ��6=   �� $ Gender: {0}��$ gender�6�   �� 5      #��[ 6   $
��Left=�6p   $��5q�6�   ��6=   �� $ UserId: {0}��$ id�6�   �� 5      #��[ 6   $
��Left=�6}   $��5q�6�   ��6=   �� $ Country: {0}��$ Coutry.name�6�   �� 5      #��[ 6   $
��Left=�6r   $��5q�6�   ��6=   �� $ 
Phone: {0}��$ phone�6�   �� 5      #��[ 6   $
��Left=�6r   $��5q�6�   ��6=   �� $ 
Email: {0}��$ email�6�   5      �� 5   
   $ Vertical=�6   $��Center=�6,   $��1��6I   $��Center=�6Y   .+�5      �� -   5        $��ProfileImage��5      $	��170��6A   $	��170��6M   ��6(   �� *image+6\   �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� -   5        $��ModifyCheckBox��5      $��5q�61   6<   �� 5      $��Center=�6   Modify Password6H   5      �� 5      -   5        $��	forMuteSP��5      $y�Hidden=�6*   .+�5       �� $ 
Horizontal=�6   $��Right=�66   .+�5!      �� #��[ 6    $��18(�6E   	Password:6_   G� 5"      -   5        $��
PasswordPB��5"   "   $	��120��64   $��25��6@   6N   5#      �� 5$      $ 
Horizontal=�6   .+�5%      �� #��[ 6    $��18(�6E   RePassword:6a   G� 5&      -   5        $��RePasswordPB��5&   "   $	��120��66   $��25��6B   6P   5'      �� 5(      $ 
Horizontal=�6   $��Center=�66   .+�5)      �� -   5        $��SavePasswordBtn��5)      $	��100��64   $��25��6@   $��5q�6L   .��6u   Save6{   �� 5*      -   5        $��CancelPasswordBtn��5*      $	��100��66   $��25��6B   $��5q�6N   .��6Y   Cancel6a   5+      5,      5-      5.      5/      